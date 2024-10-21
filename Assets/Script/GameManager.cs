using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private CoinSpawner coinSpawner;


    private void Update()
    {
        // CoinSpawnerのインスタンスにアクセスしてtotalValueを取得
        Debug.Log("合計金額: " + coinSpawner.totalValue + "円");
    }

}

