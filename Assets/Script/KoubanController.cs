using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoubanController : MonoBehaviour
{

    [SerializeField] PlayerController playerController;


    private bool isVisit = false; //すでに交番に行ったかどうかのフラグ


    public void ClickedKouban()
    {
        Debug.Log("交番がクリックされた");
        if (!isVisit)
        {
            isVisit = true;
            //お金を届ける＆視線ゲージが減る処理
        }
        else
        {
            playerController.ShowTextBox("もう訪れた交番だ");
        }
    }
}
