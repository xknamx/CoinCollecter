using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextBoxController : MonoBehaviour
{

   [SerializeField] GameObject boolTextBox;


    public bool isShowTextBox=false; //テキストボックスが表示されているかのフラグ
    TextMeshProUGUI yesSelectedText;
    TextMeshProUGUI noSelectedText;

    [SerializeField] SearchPanel searchPanel;

    private void Start()
    {
       
        yesSelectedText = boolTextBox.transform.Find("Yes").GetComponent<TextMeshProUGUI>();
        yesSelectedText = boolTextBox.transform.Find("No").GetComponent<TextMeshProUGUI>();

    }

    private void Update()
    {
        if(isShowTextBox && Input.GetKeyDown(KeyCode.Space))
        {
            CloseTextBox();
        }
    }

    public void CloseTextBox()
    {
        gameObject.SetActive(false);
        isShowTextBox = false;

    }

    public void ShowTextBox(string text, string yesText = "notext", string noText = "notext")
    {

        gameObject.SetActive(true);
        isShowTextBox = true;

        var textbox = GetComponentInChildren<TextMeshProUGUI>();
        textbox.text = text;

        if (yesText== "notext" || noText== "notext")
        {
            boolTextBox.SetActive(false);
        }
        else
        {
            boolTextBox.SetActive(true);
            yesSelectedText.text = yesText;
            noSelectedText.text = noText;
        }

        
      
    }

   

}
