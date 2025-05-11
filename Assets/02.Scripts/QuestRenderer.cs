using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class QuestRenderer : MonoBehaviour
{
    [System.Serializable]
    public class QuestDataProperty
    {
        public Sprite sprite;
        public string description;
    }
    public Button previousPageButton, nextPageButton;
    public Image questlmg;
    public TextMeshProUGUI descriptionTxt;

    public List<QuestDataProperty> questData;

    int currentPage;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateUI()
    {
        previousPageButton.interactable = currentPage > 0;
        nextPageButton.interactable = currentPage < questData.Count - 1;

        UpdateContent();
    }
    void UpdateContent()
    {
        questlmg.sprite = questData[currentPage].sprite;

        StopAllCoroutines();
        StartCoroutine(AppearTextOneByOne(0.1f));
    }

    IEnumerator AppearTextOneByOne(float interval)
    {
        int index = 3;

        string description = questData[currentPage].description;

        while(index <= description.Length)
        {
            descriptionTxt.text = description.Substring(0, index);
            yield return new WaitForSeconds(interval);
            index++;
        }
    }
    public void OnclickPrevButton()
    {
        Debug.Log("click prev button");

        currentPage--;

        UpdateUI();
    }
    public void OnclickNextButton()
    {
        Debug.Log("click next button");

        currentPage++;

        UpdateUI();

    }
}
