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
            // LineOfSight コンポーネントを取得
            LineOfSight lineOfSight = GetComponent<LineOfSight>();

            if (lineOfSight != null)
            {
                // 視線ポイントを5減らすメソッドを呼び出し
                lineOfSight.DecreaseLineOfSight(5);
                DecreaseTotalValue();
            }
            if (GameManager.Instance.totalValue >= 500)
            {
                playerController.ShowTextBox("警官の目が気になる");
            }
            else
            {
                playerController.ShowTextBox("もう訪れた交番だ");
            }
        }
    }

    //50円はらう
    void DecreaseTotalValue()
    {
        GameManager.Instance.totalValue -= 50;
    }
}
