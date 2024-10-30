using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject uiPanel; // UIパネル
    [SerializeField] PlayerController playerController; // プレイヤーの操作スクリプト

    // UIパネルを表示
    public void ShowUI()
    {
        uiPanel.SetActive(true);
        playerController.enabled = false; // プレイヤー操作を無効化
    }

    // UIパネルを非表示
    public void HideUI()
    {
        uiPanel.SetActive(false);
        playerController.enabled = true; // プレイヤー操作を再び有効化
    }
}
