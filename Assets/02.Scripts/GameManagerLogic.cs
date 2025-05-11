using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;
    

    public GameObject menuSet;
    public GameObject player;

    public GameManagerLogic manager;

    public static bool isMenuSet = false; // esc 활성화 
   
   

    void Awake()
    {
    

        stageCountText.text = "/ " + totalItemCount;
        

    }
    void Update()
    {
        

        //서브 메뉴 sube menu
        if (Input.GetButtonDown("Cancel"))
            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
              
            }

            else
            {
                menuSet.SetActive(true);
               
            }
       

        if (Input.GetButtonDown("Submit"))
            SceneManager.LoadScene(stage);
    }
   


    public void GameSave()
    {

        //PlayerPrefs.SetFloat("PlayerX", player.transform.position.x);
        //PlayerPrefs.SetFloat("PlayerY", player.transform.position.y);
        //PlayerPrefs.SetFloat("PlayerZ", player.transform.position.z);
        PlayerPrefs.SetInt("Stage", stage);
        
        PlayerPrefs.Save();

        //PlayerPrefs.GetString(stage);

        menuSet.SetActive(false);
        

    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(stage);
    }
}
