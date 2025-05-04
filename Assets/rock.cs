using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class rock : MonoBehaviour
{
    rock move;
    private void Start()
    {



       

        Material mat = GetComponent<MeshRenderer>().material;
        mat.DOBlendableColor(Color.red, 5).SetDelay(10);






    }
}
