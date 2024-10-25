using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverAnimator : MonoBehaviour
{

    private Text text; 

    void Start()
    {
        // Textコンポーネントを取得
        text = GetComponent<Text>();

        // 初期状態で透明にする
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);

        // 2秒かけてフェードイン
        text.DOFade(1, 2f);
    }
}

