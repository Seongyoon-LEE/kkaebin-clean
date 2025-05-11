using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyUi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RectTransform rt = GetComponent<RectTransform>();
        rt.DOAnchorPosY(0, 10).SetDelay(1f).SetEase(Ease.InOutBounce);


    }
}

