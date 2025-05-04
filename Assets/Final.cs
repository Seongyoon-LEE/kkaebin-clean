using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    private void OnEnable()
    {





        Text text = GetComponent<Text>();
        text.DOText("FINAL STAGE", 0.8f, true, ScrambleMode.All).SetAutoKill(true);




    }
}
