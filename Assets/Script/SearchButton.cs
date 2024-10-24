using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SearchButton : MonoBehaviour
{
    [SerializeField] private CoinSpawner coinSpawner;
    private Button button;
    // 追加: ボタンを押せる回数の上限と現在の押された回数を管理
    private int maxClickCount;
    private int currentClickCount = 0;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        // ランダムで押せる回数を決定（2回から5回の間）
        maxClickCount = Random.Range(2, 5);
    }
    private void OnClick()
    {
        int randomCoinCount = Random.Range(3, 10);

        // コインをリセットし、新しいコインを生成
        coinSpawner.SpawnRandomCoins(randomCoinCount);

        // ボタンが押された回数を増やす
        currentClickCount++;

        Debug.Log("合計金額: " + coinSpawner.totalValue + "円");
        Debug.Log("現在のクリック数: " + currentClickCount + " / " + maxClickCount);

        // クリック数が上限に達したらボタンを無効化
        if (currentClickCount >= maxClickCount)
        {
            button.interactable = false; // ボタンを無効にする
            Debug.Log("ボタンが無効化されました。");
        }
    }
}

