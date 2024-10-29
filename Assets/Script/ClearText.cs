using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClearText : MonoBehaviour
{
   // GameManager gameManager;
    void Start()
    {
       // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        GetComponent<TextMeshProUGUI>().text =
           $"あさった自販機　{GameManager.Instance.caughtVendingMachinesCount}" +
           $"" +
           $"ひろった合計金額　{GameManager.Instance.totalValue}";
    }

    
    void Update()
    {
        
    }
}
