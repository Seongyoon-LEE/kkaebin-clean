using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MoveMove : MonoBehaviour
{
    private float turnA = 0.0f;
    private bool turnon = false;

    public float startTime;

    public float minX, maxX;

    [Range(1, 100)]
    public float moveSpeed;

    private int sign = 1;

    public float rotateSpeed;
    

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            if (Time.time >= startTime)
            {


                //이동 로직  처리
                transform.position += new Vector3(moveSpeed * Time.deltaTime * sign, 0, 0);
                if (transform.position.x <= minX ||
                    transform.position.x >= maxX)
                {

                    sign *= -1;
                    turnon = true;
                }

                
            }


    }
    private void Update()
    {
        if (turnon == true)
        {

            float turn = rotateSpeed * Time.deltaTime;
            turnA += turn;


            transform.Rotate(Vector3.up * turn);
            if (turnA >= 180.0f)
            {
                turnon = false;
            }
        }
    }
}