using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogo : MonoBehaviour
{
    private float turnA = 0.0f;
    private bool turnon = false;

    public float startTime;

    public float minZ, maxZ;

    [Range(1, 100)]
    public float moveSpeed;

    private int sign = 1;

    public float rotateSpeed;

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Time.time >= startTime)
            {
                //이동 로직  처리
                transform.position += new Vector3(0, 0, sign * moveSpeed * Time.deltaTime);
                if (transform.position.z <= minZ ||
                    transform.position.z >= maxZ)
                {
                    sign *= -1;
                    turnon = true;
                }
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

