using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SearchButton : MonoBehaviour
{
    [SerializeField] private CoinSpawner coinSpawner;
    private Button button;

    [SerializeField] private LineOfSight lineOfSight;  // LineOfSight の参照

    // 追加: ボタンを押せる回数の上限と現在の押された回数を管理
    [SerializeField] private int minClickCount = 2;  // ボタンを押せる回数の最小値
    [SerializeField] private int maxClickCountRange = 5;  // ボタンを押せる回数の最大値
    private int maxClickCount;
    private int currentClickCount = 0;

    [SerializeField] private int minCoinsCount = 3;  // コイン数の最小値
    [SerializeField] private int maxCoinsCount = 10;  // コイン数の最大値

    


    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick); // OnClickメソッドをボタンのクリックに設定
        button.onClick.AddListener(() =>
        {
            AudioManager.Instance.Play("coin");
        });
        // ランダムで押せる回数を設定
        maxClickCount = Random.Range(minClickCount, maxClickCountRange); ;
    }
    private void OnClick()
    {
        // インスペクターで設定された範囲からランダムにコインの数を生成
        int randomCoinCount = Random.Range(minCoinsCount, maxCoinsCount);

        // コインをリセットし、新しいコインを生成
        coinSpawner.SpawnRandomCoins(randomCoinCount);

        // 視線ポイントを加算
        lineOfSight.IncreaseLineOfSightPoint(1);  // 1ポイントずつ加算

        // ボタンが押された回数を増やす
        currentClickCount++;

        Debug.Log("合計金額: " + GameManager.Instance.totalValue + "円");
        Debug.Log("現在のクリック数: " + currentClickCount + " / " + maxClickCount);

        // クリック数が上限に達したらボタンを無効化
        if (currentClickCount >= maxClickCount)
        {
            button.interactable = false; // ボタンを無効にする
            Debug.Log("ボタンが無効化されました。");
        }
    }

    // リセットメソッドを追加
    public void ResetButton()
    {
        currentClickCount = 0; // クリックカウントをリセット
        button.interactable = true; // ボタンを再度押せるようにする
        Debug.Log("ボタンの状態がリセットされました。");
    }
}

