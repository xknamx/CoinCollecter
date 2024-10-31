using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public static SceneChanger Instance { get; private set; }

    //private void Awake()
    //{
    //    // シングルトンの設定
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject); // シーンが切り替わっても破棄されないようにする
    //    }
    //    else
    //    {
    //        Destroy(gameObject); // すでに存在する場合はこのインスタンスを破棄
    //    }
    //}

    public void LoadTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
    public void LoadClearScene()
    {
        SceneManager.LoadScene("ClearScene");
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
        StartCoroutine(RestartSceneChange());
    }

    public void LoadFirstTown()
    {
        SceneManager.LoadScene("FirstTownMap");
    }
    public void LoadSecondTown()
    {
        SceneManager.LoadScene("SecondTown");
    }

    IEnumerator RestartSceneChange()
    {
        yield return new WaitForSeconds(10);
        LoadTitleScene();

    }
}
