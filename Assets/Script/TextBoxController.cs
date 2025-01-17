using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextBoxController : MonoBehaviour
{

    [SerializeField] GameObject boolTextBox;


    public bool isShowTextBox = false; //テキストボックスが表示されているかのフラグ
    [SerializeField] GameObject yesSelectedText;
    [SerializeField] GameObject noSelectedText;

    [SerializeField] SearchPanel searchPanel;

    private void Start()
    {



        gameObject.SetActive(false);
        isShowTextBox = false;
    }

    public void CloseTextBox()
    {
        StartCoroutine(WaitAndHideTextBox());
    }


   
    private IEnumerator WaitAndHideTextBox()
    {
        yield return null; // 1フレーム待機

        gameObject.SetActive(false);
        isShowTextBox = false;
    }

    public void ShowTextBox(string text, string yesText = "notext", string noText = "notext")
    {

        gameObject.SetActive(true);
        isShowTextBox = true;

        var textbox = GetComponentInChildren<TextMeshProUGUI>();
        textbox.text = text;

        if (yesText == "notext" || noText == "notext")
        {
            boolTextBox.SetActive(false);
        }
        else
        {
            boolTextBox.SetActive(true);
            yesSelectedText.GetComponentInChildren<TextMeshProUGUI>().text = yesText;
            noSelectedText.GetComponentInChildren<TextMeshProUGUI>().text = noText;

        }



    }



}
