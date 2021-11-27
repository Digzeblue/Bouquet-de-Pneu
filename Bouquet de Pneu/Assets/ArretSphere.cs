using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArretSphere : MonoBehaviour
{
    public GameObject spacebarTuto;
    public float time = 20;
    private bool stop = false;
    private bool tutoDone = false;

    private float rAmount;
    private rotation mvtSphere;

    // Start is called before the first frame update
    void Start()
    {
        mvtSphere = GameObject.Find("Sphere").GetComponent<rotation>();

        // affichage du tuto appuie sur une touche et retour à la normal 
        // faire un script intégration

        
    }
    // Update is called once per frame
    void Update()
    {

        if (time >= 0)
        {
            time -= Time.deltaTime;
        }

        if (time <= 0 && !stop)
        {
            Debug.Log("Stop !");
            stop = true;
            rAmount = mvtSphere.RotateAmount;
            mvtSphere.RotateAmount = 0;

            //Affiche le tuto
            spacebarTuto.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E) && stop && !tutoDone)
        {
            Debug.Log("LEDZGO");
            tutoDone = true;
            mvtSphere.RotateAmount = rAmount;

            //Disparaître UI tuto
            spacebarTuto.SetActive(false);
        }

    }

}
