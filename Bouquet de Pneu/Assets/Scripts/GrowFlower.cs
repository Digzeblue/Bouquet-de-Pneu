using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowFlower : MonoBehaviour
{
    public float radius;        //Rayon planète

    public GameObject player;
    public GameObject flower;   //fleur à créer

    public float cooldown;      //Durée fixe du cooldown
    private float nextFlower;   //Prochain timing où on peut agir

    private Vector3 center;
    private float spawnRange = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(Time.time > nextFlower)  //Si le cooldown est dépassé
            {
                nextFlower = Time.time + cooldown;  //reset timer

                Vector3 posPlayer = player.transform.position;

                //On prend une position aléatoire dans un cercle autour du joueur
                Vector3 pos = new Vector3(
                    posPlayer.x + Random.Range(-spawnRange, spawnRange),
                    posPlayer.y + Random.Range(-spawnRange, spawnRange),
                    posPlayer.z);
                pos.z += 0.2f * Vector3.Distance(posPlayer, pos);

                //On oriente la fleur vers le centre de la planète
                Quaternion rot = Quaternion.FromToRotation(Vector3.up, center - pos);

                //On crée une fleur qui a la planète pour parent
                GameObject f = Instantiate(flower, pos, rot);
                f.transform.parent = this.transform;
            }
        }
    }

}
