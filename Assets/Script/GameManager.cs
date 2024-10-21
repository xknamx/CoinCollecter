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

        // �R�C�������Z�b�g���A�V�����R�C���𐶐�
        coinSpawner.SpawnRandomCoins(randomCoinCount);

        Debug.Log("���v���z: " + coinSpawner.totalValue + "�~");
    }
}

