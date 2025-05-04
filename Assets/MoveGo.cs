using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveGo : MonoBehaviour
{


    private float turnA = 0.0f;
    private bool turnon = false;

    public float startTime;

    public float minZ, maxZ;

    [Range(1, 100)]
    public float moveSpeed;

    private int sign = 1;

    public float rotateSpeed;

    public rock move;
    public rock rock;
    public rock GetRock;
    public rock GetMove;
    public rock Getrock;
    public rock Getmove;
    public rock Getget;
    public rock GetGet;
    public rock r;
    public rock o;
    public rock c;
    public rock k;

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
            Getmove.transform.DOMove(Vector3.back, 10).SetDelay(15);
            Getmove.transform.DOScale(Vector3.one * 3, 5).SetDelay(15);
            Getmove.transform.DORotate(Vector3.up, 5).SetDelay(15);

            Getget.transform.DOMove(Vector3.back, 10).SetDelay(12);
            Getget.transform.DOScale(Vector3.one * 3, 5).SetDelay(12);
            Getget.transform.DORotate(Vector3.up, 5).SetDelay(12);

            GetGet.transform.DOMove(Vector3.back, 10).SetDelay(9);
            GetGet.transform.DOScale(Vector3.one * 3, 5).SetDelay(9); 
            GetGet.transform.DORotate(Vector3.up, 5).SetDelay(9);

            r.transform.DOMove(Vector3.back, 10).SetDelay(8);
            r.transform.DOScale(Vector3.one * 3, 5).SetDelay(8);

            o.transform.DOMove(Vector3.back, 10).SetDelay(7);
            o.transform.DOScale(Vector3.one * 3, 5).SetDelay(7);

            c.transform.DOMove(Vector3.back, 10).SetDelay(6);
            c.transform.DOScale(Vector3.one * 3, 5).SetDelay(6);

            k.transform.DOMove(Vector3.back, 10).SetDelay(4);
            k.transform.DOScale(Vector3.one * 3, 5).SetDelay(4);


            move.transform.DOMove(Vector3.back, 10).SetDelay(3);
            move.transform.DOScale(Vector3.one * 3, 5).SetDelay(3);
            move.transform.DORotate(Vector3.up, 5).SetDelay(3);

            rock.transform.DOMove(Vector3.back, 10).SetDelay(2);
            rock.transform.DOScale(Vector3.one * 3, 5).SetDelay(2);
            rock.transform.DORotate(Vector3.forward, 5).SetDelay(2);

            GetRock.transform.DOMove(Vector3.back, 10).SetDelay (1.5f);
            GetRock.transform.DOScale(Vector3.one * 3, 5).SetDelay(1.5f);
            GetRock.transform.DORotate(Vector3.up, 5).SetDelay(1.5f);

            GetMove.transform.DOMove(Vector3.back, 10).SetDelay(1);
            GetMove.transform.DOScale(Vector3.one * 3, 5).SetDelay(1);
            GetMove.transform.DORotate(Vector3.up, 5).SetDelay(1);

            Getrock.transform.DOMove(Vector3.back, 10);
            Getrock.transform.DOScale(Vector3.one * 3, 5);
            Getrock.transform.DORotate(Vector3.up, 5); 



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