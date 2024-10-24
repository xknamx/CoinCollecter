using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player; //追従させるプレイヤーオブジェクト
    [SerializeField] float cameraPosMinX = -9; //左端のカメラ限界位置設定
    [SerializeField] float cameraPosMaxX = 9;  //右端のカメラ限界位置設定

    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player"); //Playerタグのついたオブジェクトを探してセット
    }
    void Update()
    {
        Vector3 playerPos = this.player.transform.position; //取得したプレイヤーの位置

        if (playerPos.x < cameraPosMinX)
        {
            transform.position = new Vector3(cameraPosMinX, transform.position.y, transform.position.z);
            //プレイヤーが画面端付近にいるときは画面端でカメラ固定
        }
        else if (cameraPosMaxX < playerPos.x )
        {
            transform.position = new Vector3(cameraPosMaxX, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
            //プレイヤーが画面端付近にいないときはx座標を追従する
        }
    }
}
