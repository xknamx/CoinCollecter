using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleAnimetor : MonoBehaviour
{
    [SerializeField] private Image image; // フェードインさせるタイトルテキスト
    [SerializeField] private float fadeDuration = 2f;   // フェードインの時間

    private void Start()
    {
        // フェードインを開始
        StartCoroutine(FadeInTitle());
    }

    private IEnumerator FadeInTitle()
    {
        // アルファ値を0にして、最初は見えないようにする
        Color color = image.color;
        color.a = 0;
        image.color = color;

        float elapsedTime = 0f;

        // フェードインループ
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            // アルファ値を増加させてフェードインを実現
            color.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            image.color = color;

            yield return null; // 次のフレームまで待機
        }

        // 完全にフェードインさせるためにアルファ値を1に設定
        color.a = 1;
        image.color = color;
    }
}