using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private CoinSpawner coinSpawner;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        int randomCoinCount = Random.Range(3, 10);

        // コインをリセットし、新しいコインを生成
        coinSpawner.SpawnRandomCoins(randomCoinCount);

        Debug.Log("合計金額: " + coinSpawner.totalValue + "円");
    }
}

