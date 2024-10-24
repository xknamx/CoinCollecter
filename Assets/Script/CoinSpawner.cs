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
            // コインの種類をランダムに決める
            int coinType = Random.Range(0, 4);  // 0: 1円, 1: 5円, 2: 10円, 3: 50円
            GameObject coinPrefabToSpawn;


            switch (coinType)
            {
                case 0:
                    coinPrefabToSpawn = oneYenPrefab;
                    coinValue = 1;
                    break;
                case 1:
                    coinPrefabToSpawn = fiveYenPrefab;
                    coinValue = 5;
                    break;
                case 2:
                    coinPrefabToSpawn = tenYenPrefab;
                    coinValue = 10;
                    break;
                case 3:
                    coinPrefabToSpawn = fiftyYenPrefab;
                    coinValue = 50;
                    break;
                default:
                    coinPrefabToSpawn = oneYenPrefab;  // デフォルトで1円にする
                    coinValue = 1;
                    break;
            }
            // コインを生成し、リストに追加
            GameObject spawnedCoin = Instantiate(coinPrefabToSpawn, GetRandomPosition(), Quaternion.identity);
            spawnedCoins.Add(spawnedCoin);  // 生成したコインをリストに追加

            totalValue += coinValue;
        }
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