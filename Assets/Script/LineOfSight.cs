using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineOfSight : MonoBehaviour
{
    private int lineOfSightPoint = 0;  // 視線ポイントの初期値
    public int maxLineOfSightPoint = 100;  // 視線ポイントの上限値
    [SerializeField] private Image LineOfSightBar; // ゲージのイメージ

    public void Start()
    {
        UpdateGauge();
    }


    // 視線ポイントを加算するためのメソッド
    public void IncreaseLineOfSightPoint(int amount)
    {
        // 視線ポイントを加算
        GameManager.Instance.LightOfSightPoint += amount;

        // 視線ポイントが上限を超えたらゲームオーバー
        if (GameManager.Instance.LightOfSightPoint >= maxLineOfSightPoint)
        {
            SceneChanger.Instance.LoadGameOverScene();
           // lineOfSightPoint = maxLineOfSightPoint;
           
        }

        // ゲージの表示を更新
        UpdateGauge();

        Debug.Log("視線ポイント: " + GameManager.Instance.LightOfSightPoint);
    }

    public void DecreaseLineOfSight(int amount)
    {
        if (GameManager.Instance.LightOfSightPoint > 0)
        {
            GameManager.Instance.LightOfSightPoint -= amount;
            UpdateGauge();
        }
    }

    // ゲージの表示を更新するメソッド
    public void UpdateGauge()
    {
        // fillAmountを視線ポイントの割合に応じて更新 (0 ～ 1 の範囲)
        float fillAmount = (float)GameManager.Instance.LightOfSightPoint / maxLineOfSightPoint;
        LineOfSightBar.fillAmount = fillAmount;
    }

    // 視線ポイントを取得するメソッド
    public int GetLineOfSightPoint()
    {
        return GameManager.Instance.LightOfSightPoint;
    }
}

