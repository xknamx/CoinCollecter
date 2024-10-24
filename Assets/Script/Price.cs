using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Price : MonoBehaviour
{
    [SerializeField] private CoinSpawner coinSpawner; // CoinSpawner���C���X�y�N�^�Őݒ�ł���悤�ɂ���
    private TextMeshProUGUI textMeshPro; // TextMeshProUGUI�̎Q��

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
            textMeshPro.text = "������: " + coinSpawner.totalValue.ToString() + "�~";
    }
}
