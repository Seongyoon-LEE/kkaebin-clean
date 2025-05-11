using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public float rotateSpeed;


    private float turnA = 0.0f;
    private bool turnon = false;



    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            turnon = true;

            if (turnon == true)
            {

                float turn = rotateSpeed * Time.deltaTime;
                turnA += turn;




                transform.Rotate(Vector3.right * turn);
                if (turnA >= 90.0f)
                {
                    turnon = false;
                }
            }
        }
    }
}
        
    
            /* if (transform.rotation.x <= maxX)
            {
               transform.Rotate(new Vector3(1, 0, 0) * rotateSpeed * Time.deltaTime);
            }
            */



            //transform.rotation = new Quaternion(rotateSpeed * Time.deltaTime, 0, 0, 0);

            // transform.rotation = new Quaternion(rotateSpeed * Time.deltaTime, 0, 0);
            // transform.Rotate(Vecotr3.up * rotateSpeed * Time.deltaTime)
            // gameObject.transform.eulerAngles = new Vector3(90, 0, 0);


        

    
 
