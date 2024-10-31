using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoubanController : MonoBehaviour
{

    [SerializeField] PlayerController playerController;
    private LineOfSight lineOfSight;  // LineOfSight の参照


    private bool isVisit = false; //すでに交番に行ったかどうかのフラグ

    public void Start()
    {
        // LineOfSight コンポーネントを取得して lineOfSight フィールドに代入
        lineOfSight = FindObjectOfType<LineOfSight>();
    }

    public void ClickedKouban()
    {
        Debug.Log("交番がクリックされた");
        if (!isVisit)
        {
            // 視線ポイントを5減らすメソッドを呼び出し
            lineOfSight.DecreaseLineOfSight(2);
            DecreaseTotalValue();

            //ゲージをアップデート
            lineOfSight.UpdateGauge();

            Debug.Log(GameManager.Instance.LightOfSightPoint);
        }
        else
        {
            playerController.ShowTextBox("もう訪れた交番だ");
        }
    }


    //50円はらう
    public void DecreaseTotalValue()
    {
        GameManager.Instance.totalValue -= 50;
    }
}
