using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    public GameObject player;
    public GameManagerLogic manager;
   
    public void OnClickStartBtn()
    {
        Debug.Log("Clicked start btn");
        
        SceneManager.LoadScene(manager.stage + 1);
    }

    public void OnClickExitBtn()
    {
        Debug.Log("Clicked Exit btn");

        // save any game data here
#if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }



    public void OnClickLoadingBtn()
    {
        //if (!PlayerPrefs.HasKey("PlayerX"))
            //return;

        Debug.Log("Clicked Loading btn");
        //float x = PlayerPrefs.GetFloat("PlayerX");
        //float y = PlayerPrefs.GetFloat("PlayerY");
        //float z = PlayerPrefs.GetFloat("PlayerZ");

        //player.transform.position = new Vector3(x, y, z);

        manager.stage = PlayerPrefs.GetInt("Stage");

        SceneManager.LoadScene(manager.stage);
    }
}
