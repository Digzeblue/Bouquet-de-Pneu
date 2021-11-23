using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float startDashTime;
    public float dashSpeed;

    private float dashTime;
    public float cooldown;
    private float nextDash;

    private bool isDashing;

    private float initialSpeed;
    // Start is called before the first frame update
    void Start()
    {
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time > nextDash)
            {
                nextDash = Time.time + cooldown;    //start cooldown
                isDashing = true;

                initialSpeed = gameObject.GetComponent<rotation>().getSpeed();
                gameObject.GetComponent<rotation>().changeSpeed(initialSpeed * dashSpeed);
            }
        }

        if(isDashing)
        {
            if(dashTime <= 0)               //si dash fini
            {
                isDashing = false;
                dashTime = startDashTime;   //reset durée dash
                gameObject.GetComponent<rotation>().changeSpeed(initialSpeed); //on remet la bonne vitesse
            } else                          //si on est toujours en train de dasher
            {
                dashTime -= Time.deltaTime;
            }
        }

    }
}
