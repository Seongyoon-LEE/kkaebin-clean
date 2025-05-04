using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
  
    public int itemCount;
    public GameManagerLogic manager;
    
   
    new AudioSource audio;
    Skybox sky;

    void Awake()
    {
    
        audio = GetComponent<AudioSource>();
        sky = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Skybox>();





    }






    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {  
            
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
            sky.enabled = false;





        }
        else if(other.tag == "Point")
        {
          if(itemCount == manager.totalItemCount)
            {
                //Game Clear! && Next Stage
                if (manager.stage == 10)
                    SceneManager.LoadScene("0");
                SceneManager.LoadScene(manager.stage + 1);
            }
            else
            { 
                //Restarat Stage
                SceneManager.LoadScene(manager.stage);
            }
        }
    }


}
 