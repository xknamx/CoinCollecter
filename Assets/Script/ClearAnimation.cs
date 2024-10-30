using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateAnimation : MonoBehaviour
{
    [SerializeField] float scrollSpeed = 20f; // スクロールの速度
    [SerializeField] float offScreenYPosition = 500f;  // 画面外と判断する Y 座標

    // Update is called once per frame
    void Update()
    {
        // テキストを上にスクロールさせる
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);

        // テキストが画面外に出たかを確認
        if (rectTransform.anchoredPosition.y > offScreenYPosition)
        {
            // タイトルシーンに遷移
            SceneChanger.Instance.LoadTitleScene();
        }
    }
}
