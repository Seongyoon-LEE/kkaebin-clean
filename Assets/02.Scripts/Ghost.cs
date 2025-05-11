using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Ghost : MonoBehaviour
{
    
    public int moveSpeed;
    // Start is called before the first frame update
    private void Start()
    {






        transform.DOMove(Vector3.forward, 10);
       




    }

    // Update is called once per frame
    void Update()
    {
    

      
    
    }
}
