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

    private void Start()
    {
        int randomCoinCount = Random.Range(3, 10);
        SpawnRandomCoins(randomCoinCount);

    }



    // �R�C���������_���ɐ������郁�\�b�h
    public void SpawnRandomCoins(int coinCount)
    {
        for (int i = 0; i < coinCount; i++)
        {
            // �R�C���̎�ނ������_���Ɍ��߂�
            int coinType = Random.Range(0, 4);  // 0: 1�~, 1: 5�~, 2: 10�~, 3: 50�~
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
                    coinPrefabToSpawn = oneYenPrefab;  // �f�t�H���g��1�~�ɂ���
                    coinValue = 1;
                    break;
            }
            // �R�C���𐶐�
            Instantiate(coinPrefabToSpawn, GetRandomPosition(), Quaternion.identity);
            totalValue += coinValue;
        }
    }

    // �����_���Ȉʒu���擾���郁�\�b�h
    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-5f, 5f);
        float y = Random.Range(-1f, -2f);
        float z = Random.Range(-5f, 5f);
        return new Vector3(x, y, z);
    }
}