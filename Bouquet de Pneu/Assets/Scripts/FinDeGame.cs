using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDeGame : MonoBehaviour
{
    public GameObject joe;
    public GameObject mcamera;
    //Vector3 pointArriveJoe = new Vector3(20, 5, 15);
    Vector3 pointArriveCamera = new Vector3(0, 0, -200);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        mcamera.transform.position = Vector3.MoveTowards(mcamera.transform.position, pointArriveCamera, 0.1f);
        if (mcamera.transform.position == pointArriveCamera) EndGame();
    }

    void EndGame()
    {
        //Planet.RotationStop()
        //joe.transform.position = Vector3.MoveTowards(joe.transform.position,pointArriveJoe, 0.1f);
    }
}
