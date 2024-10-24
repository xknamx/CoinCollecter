using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Dependencies.Sqlite.SQLite3;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject oneYenPrefab;
    [SerializeField] private GameObject fiveYenPrefab;
    [SerializeField] private GameObject tenYenPrefab;
    [SerializeField] private GameObject fiftyYenPrefab;
    public int totalValue = 0;
    private int coinValue = 0;
    private List<GameObject> spawnedCoins = new List<GameObject>(); // 生成したコインを管理するリスト

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

            // コインを生成し、リストに追加
            GameObject spawnedCoin = Instantiate(coinPrefabToSpawn, GetRandomPosition(), Quaternion.identity);
            spawnedCoins.Add(spawnedCoin);  // 生成したコインをリストに追加

            totalValue += coinValue;
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
    // コインをリセット（削除）するメソッド
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
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-1f, -2f);
        float z = Random.Range(-5f, 5f);
        return new Vector3(x, y, z);
    }
}