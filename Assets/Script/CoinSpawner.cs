using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Dependencies.Sqlite.SQLite3;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject oneYenPrefab;
    [SerializeField] private GameObject fiveYenPrefab;
    [SerializeField] private GameObject tenYenPrefab;
    [SerializeField] private GameObject fiftyYenPrefab;

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
                    break;
                case 1:
                    coinPrefabToSpawn = fiveYenPrefab;
                    break;
                case 2:
                    coinPrefabToSpawn = tenYenPrefab;
                    break;
                case 3:
                    coinPrefabToSpawn = fiftyYenPrefab;
                    break;
                default:
                    coinPrefabToSpawn = oneYenPrefab;  // �f�t�H���g��1�~�ɂ���
                    break;
            }
            // �R�C���𐶐�
            Instantiate(coinPrefabToSpawn, GetRandomPosition(), Quaternion.identity);
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