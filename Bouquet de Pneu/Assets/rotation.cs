using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotation : MonoBehaviour
{
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public float RotateAmount = 1;
    public bool rotate;
    public bool rotateConstantly;

    // Start is called before the first frame update
    void Start()
    {
        startQuaternion = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotate)
        transform.rotation = Quaternion.Lerp(transform.rotation, startQuaternion, Time.deltaTime * lerpTime);
        // si je coche rotate et que la sphère n'est pas dans ça position initial = elle se remet en plus
        if (rotateConstantly)
        {
            
                if (Input.GetKey(KeyCode.Z))
                {
                    transform.Rotate(Vector3.up * RotateAmount);
                }
                //Sinon si j'appuie sur S
                else if (Input.GetKey(KeyCode.S))
                {
                    transform.Rotate(Vector3.down * RotateAmount);
                }
            

            if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    transform.Rotate(Vector3.right * RotateAmount);
                    transform.Rotate(Vector3.up * RotateAmount);
                }
                //Sinon si j'appuie sur S
                else if (Input.GetKey(KeyCode.S))
                {
                    transform.Rotate(Vector3.right * RotateAmount);
                    transform.Rotate(Vector3.down * RotateAmount);
                }
                //Sinon
                else transform.Rotate(Vector3.right * RotateAmount);
            }
            
            if (Input.GetKey(KeyCode.Q))
            {
                if (Input.GetKey(KeyCode.Z))
                {
                    transform.Rotate(Vector3.left * RotateAmount);
                    transform.Rotate(Vector3.up * RotateAmount);
                }
                //Sinon si j'appuie sur S
                else if (Input.GetKey(KeyCode.S))
                {
                    transform.Rotate(Vector3.left * RotateAmount);
                    transform.Rotate(Vector3.down * RotateAmount);
                }
                //Sinon
                else transform.Rotate(Vector3.left * RotateAmount);
            }
        }
            
        // rotate constantly = la sphère tourne à l'infinie
        // .right c'est le sens de la rotation (on peut mettre .up à la place)

        // j'ai rien compris de la dernière partie avec reverse quaternion 
        //les cases a cocher sont les variables bool ? et du coup on peut s'amuser avec vrai faux ? OUI

        // test code :

        if (Input.GetKeyDown(KeyCode.A)) { 
            rotateConstantly = true;
            //transform.Rotate(Vector3.left* RotateAmount);
        }

        

        // autre méthode pour faire tourner la sphère sur un axe X dans update transform.rotate(new Vector3(0f, 0f, 100f)* Time.deltaTime);
    }

    public void snapRotation() 
    {
        transform.rotation = startQuaternion;

    }
}
