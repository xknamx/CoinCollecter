using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int totalValue { get; set; }  // コインの合計金額を保持する変数
    public int caughtVendingMachinesCount { get; set; }  //漁った自販機の個数を保存
    public int policeStationVisitsCount { get; set; }  //交番に行った回数
    public int deliveredAmount { get; set; } 　//届けた金額
    public int SeenCount { get; set; } //見られた回数
    public int reportCount { get; set; }  //通報された回数
    public int drinksConsumedCount { get; set; }  //飲み物を飲んだ回数

    public int finalAmountValue { get; set; } //最終的に残った金額


    private void Awake()
    {
        // シングルトンの設定
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーンが切り替わっても破棄されないようにする
        }
        else
        {
            Destroy(gameObject); // すでに存在する場合はこのインスタンスを破棄
        }
    }

    public void ExitGame() //ゲームを終了するメソッド
    {
        Application.Quit();

        // エディタで実行中の場合
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // エディタのプレイモードを停止
#endif
    }
}
