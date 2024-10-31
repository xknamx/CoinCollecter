using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoubanController : MonoBehaviour
{

    [SerializeField] PlayerController playerController;
    private LineOfSight lineOfSight;  // LineOfSight の参照


    //private bool isVisit = false; //すでに交番に行ったかどうかのフラグ

    [SerializeField]TextBoxController textBox;

    public void Start()
    {
        // LineOfSight コンポーネントを取得して lineOfSight フィールドに代入
        lineOfSight = FindObjectOfType<LineOfSight>();
    }

    public void ClickedKouban()
    {
        if (textBox.isShowTextBox)
        {
            return;
        }

        Debug.Log("交番がクリックされた");
        if (GameManager.Instance.totalValue - 50 <= 0)
        {
            textBox.ShowTextBox("こんな額届けても…");
            return; 
        }
            textBox.ShowTextBox("交番にお金を届けようか…","とどける","とどけない");
        
       
            Debug.Log(GameManager.Instance.LightOfSightPoint);
       
    }


    //50円はらう
    public void DecreaseTotalValue()
    {
        
        GameManager.Instance.totalValue -= 50;
    }
}
