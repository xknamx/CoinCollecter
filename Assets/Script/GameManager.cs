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
        // CoinSpawner�̃C���X�^���X�ɃA�N�Z�X����totalValue���擾
        Debug.Log("���v���z: " + coinSpawner.totalValue + "�~");
    }

}

