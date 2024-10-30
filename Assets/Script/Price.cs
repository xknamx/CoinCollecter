using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Price : MonoBehaviour
{
   // [SerializeField] private GameManager gameManager; // CoinSpawnerをインスペクタで設定できるようにする
    private TextMeshProUGUI textMeshPro; // TextMeshProUGUIの参照

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = GameManager.Instance.totalValue.ToString();
    }
}
