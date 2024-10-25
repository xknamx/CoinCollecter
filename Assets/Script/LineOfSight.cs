using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineOfSight : MonoBehaviour
{
    private int lineOfSightPoint = 0;  // 視線ポイントの初期値
    public int maxLineOfSightPoints = 100;  // 視線ポイントの上限値

    [SerializeField] private Slider lineOfSightSlider;  // スライダーの参照をインスペクターから設定

    private void Start()
    {
        // スライダーの最大値を設定
        lineOfSightSlider.maxValue = maxLineOfSightPoints;
        lineOfSightSlider.value = lineOfSightPoint;
    }

    // 視線ポイントを加算するためのメソッド
    public void IncreaseLineOfSightPoint(int amount)
    {
        lineOfSightPoint += amount;

        // 視線ポイントが上限を超えないように制限
        if (lineOfSightPoint > maxLineOfSightPoints)
        {
            lineOfSightPoint = maxLineOfSightPoints;
        }

        // スライダーの値を更新
        lineOfSightSlider.value = lineOfSightPoint;

        Debug.Log("視線ポイント: " + lineOfSightPoint);
    }

    // 視線ポイントを取得するメソッド
    public int GetLineOfSightPoint()
    {
        return lineOfSightPoint;
    }
}

