using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SearchButton : MonoBehaviour
{
    [SerializeField] private CoinSpawner coinSpawner;
    private Button button;
    // �ǉ�: �{�^����������񐔂̏���ƌ��݂̉����ꂽ�񐔂��Ǘ�
    private int maxClickCount;
    private int currentClickCount = 0;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        // �����_���ŉ�����񐔂�����i2�񂩂�5��̊ԁj
        maxClickCount = Random.Range(2, 5);
    }
    private void OnClick()
    {
        int randomCoinCount = Random.Range(3, 10);

        // �R�C�������Z�b�g���A�V�����R�C���𐶐�
        coinSpawner.SpawnRandomCoins(randomCoinCount);

        // �{�^���������ꂽ�񐔂𑝂₷
        currentClickCount++;

        Debug.Log("���v���z: " + coinSpawner.totalValue + "�~");
        Debug.Log("���݂̃N���b�N��: " + currentClickCount + " / " + maxClickCount);

        // �N���b�N��������ɒB������{�^���𖳌���
        if (currentClickCount >= maxClickCount)
        {
            button.interactable = false; // �{�^���𖳌��ɂ���
            Debug.Log("�{�^��������������܂����B");
        }
    }
}

