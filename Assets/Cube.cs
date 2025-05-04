using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       

        transform.DOScale(Vector3.one * 3, 5);
        transform.DORotate(Vector3.forward, 5);

        Material mat = GetComponent<MeshRenderer>().material;
        mat.DOColor(Color.red, 5);

    }

 
}
