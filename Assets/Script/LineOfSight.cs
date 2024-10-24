using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{

    private int lineOfSightPoint = 0;

    // 視線ポイントを加算するためのメソッド
    public void IncreaseLineOfSightPoint()
    {
        lineOfSightPoint++;
        Debug.Log("視線ポイント: " + lineOfSightPoint);
    }
    // 視線ポイントを取得するメソッド
    public int GetLineOfSightPoint()
    {
        return lineOfSightPoint;
    }
}

