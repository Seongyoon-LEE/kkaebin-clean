using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float startTime;

    public float minY, maxY;

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
                transform.position += new Vector3(0, sign , 0 * moveSpeed * Time.deltaTime);
                if (transform.position.z <= minY ||
                    transform.position.z >= maxY)
                {
                   

                }
            }


        }
    }
}