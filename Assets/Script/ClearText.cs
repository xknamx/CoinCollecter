using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClearText : MonoBehaviour
{


    void Start()
    {
        // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        GetComponent<TextMeshProUGUI>().text =
                       $"あさった自販機数：{GameManager.Instance.caughtVendingMachinesCount}個\n" +
                       $"ひろった合計金額：{GameManager.Instance.totalValue}円";
    }
}
