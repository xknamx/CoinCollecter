using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] GameObject gamemanager;
    [SerializeField] private RectTransform rectTransform; //canvasのrecttransformをセット

    [SerializeField] private GameObject oneYenPrefab;
    [SerializeField] private GameObject fiveYenPrefab;
    [SerializeField] private GameObject tenYenPrefab;
    [SerializeField] private GameObject fiftyYenPrefab;

    //▼GameManagerに移動
    public int totalValue = 0;
    private int coinValue = 0;
    private List<GameObject> spawnedCoins = new List<GameObject>(); // 生成したコインを管理するリスト

    [SerializeField] private int clearAmount; //集めたらクリアになる金額

    [SerializeField] private float oneYenProbability = 0.4f;  // 1円コインの出現確率
    [SerializeField] private float fiveYenProbability = 0.3f; // 5円コインの出現確率
    [SerializeField] private float tenYenProbability = 0.2f;  // 10円コインの出現確率
    [SerializeField] private float fiftyYenProbability = 0.1f; // 50円コインの出現確率

    


    private void Start()
    {

        //int randomCoinCount = Random.Range(3, 10);
        //SpawnRandomCoins(randomCoinCount);

    }



    // コインをランダムに生成するメソッド
    public void SpawnRandomCoins(int coinCount)
    {
        // 既存のコインをリセットする処理
        ResetCoins();

        for (int i = 0; i < coinCount; i++)
        {
            // ランダムにコインの種類を決定
            GameObject coinPrefabToSpawn = GetRandomCoin();
            int coinValue = GetCoinValue(coinPrefabToSpawn);


            GameObject spawnedCoin = Instantiate(coinPrefabToSpawn, rectTransform); //canvas上にコインを生成
            spawnedCoin.GetComponent<RectTransform>().anchoredPosition = GetRandomPosition(); //位置をランダムに
            spawnedCoin.GetComponent<RectTransform>().localEulerAngles = new Vector3(0, 0, Random.Range(0, 360));


            spawnedCoins.Add(spawnedCoin);  // 生成したコインをリストに追加

            GameManager.Instance.totalValue += coinValue;　//合計金額にプラス
        }
    }

    // ランダムなコインを確率に基づいて取得するメソッド
    private GameObject GetRandomCoin()
    {
        float randomValue = Random.Range(0f, 1f); // 0から1までのランダムな値を取得

        if (randomValue < oneYenProbability)
        {
            return oneYenPrefab;
        }
        else if (randomValue < oneYenProbability + fiveYenProbability)
        {
            return fiveYenPrefab;
        }
        else if (randomValue < oneYenProbability + fiveYenProbability + tenYenProbability)
        {
            return tenYenPrefab;
        }
        else
        {
            return fiftyYenPrefab;
        }
    }

    // コインの価値を返すメソッド
    private int GetCoinValue(GameObject coinPrefab)
    {
        if (coinPrefab == oneYenPrefab)
        {
            return 1;
        }
        else if (coinPrefab == fiveYenPrefab)
        {
            return 5;
        }
        else if (coinPrefab == tenYenPrefab)
        {
            return 10;
        }
        else if (coinPrefab == fiftyYenPrefab)
        {
            return 50;
        }
        return 0;
    }

    // コイン画像表示を削除するメソッド
    private void ResetCoins()
    {
        // 既存のコインをすべて削除
        foreach (GameObject coin in spawnedCoins)
        {
            Destroy(coin);
        }

        // コインリストをクリア
        spawnedCoins.Clear();
    }

    // ランダムな位置を取得するメソッド
    private Vector2 GetRandomPosition()
    {
        float x = Random.Range(-400f, 400f);
        float y = Random.Range(-100f, -200f);

        return new Vector2(x, y);
    }
}