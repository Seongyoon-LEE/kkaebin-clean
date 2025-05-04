using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Runtime.CompilerServices;



public class MyText : MonoBehaviour
{
   
    public int stage;

    // Start is called before the first frame update


    private void OnEnable()
    {


        
        

        Text text = GetComponent<Text>();
        text.DOText("STAGE " + stage, 0.8f, true, ScrambleMode.All).SetAutoKill(true);




    }
}


  

  

