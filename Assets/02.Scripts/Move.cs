using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Move : MonoBehaviour
{
    public float startTime;

    public float minZ, maxZ;

    [Range(1, 100)]
    public float moveSpeed;

    private int sign = 1;



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
                }
            }
            

        }
    }
}