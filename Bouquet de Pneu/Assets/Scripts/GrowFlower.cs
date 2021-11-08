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

                Vector3 pos = player.transform.position;
                Quaternion rot = Quaternion.FromToRotation(Vector3.up, center - pos);
                Instantiate(flower, pos, rot);
            }
        }
    }
}
