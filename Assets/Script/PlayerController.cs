using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;    //移動速度
    [SerializeField] Animator animator;     //Animatorのセット
    Vector3 playerPos; //プレイヤーの位置
    [SerializeField] float playerPosMinX = -17.5f;  //プレイヤーの左端移動可能位置
    [SerializeField] float playerPosMaxX = 17.5f;　//プレイヤーの右端移動可能位置

    SpriteRenderer spriteRenderer;
    GameObject vendingMachine; //自販機のプレハブ
    bool isFrontVendingMachine = false; //自販機の前にいるかのフラグ


    private void Awake()
    {
        playerPos = new Vector3(playerPosMinX, -2f,transform.position.z);
        //左端からスタート

    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        PlayerMoving();

        // 自販機の前にいるとき、スペースが押されたら自販機を探す
        if (isFrontVendingMachine && Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("speed", 0.0f);
            animator.SetTrigger("behind"); //奥を向く
            vendingMachine.GetComponent<VendingMachineController>().ClickedVendingMachineOnMap();
        }
    }

    //プレイヤーの移動処理
    void PlayerMoving()
    {
        float horizontal = Input.GetAxis("Horizontal"); // ←→またはADキー入力を検出
        float vertical = Input.GetAxis("Vertical");     // ↑↓またはWSキー入力を検出

        if (vertical < 0) //下入力されたとき
        {
            animator.SetTrigger("front");　//手前を向く
        }

        if (vertical > 0)　//上入力されたとき
        {
            animator.SetTrigger("behind");　//奥を向く
        }



        if (horizontal != 0)
        {

            if (horizontal > 0) //左入力されたとき
            {
                spriteRenderer.flipX = false; //左を向く
            }
            else if (horizontal < 0) //右入力されたとき
            {
                spriteRenderer.flipX = true; //右を向く
            }
            playerPos.x += horizontal * speed * 60.0f * Time.deltaTime;
            animator.SetFloat("speed", 1.0f);


            if (playerPosMinX < playerPos.x && playerPos.x < playerPosMaxX)
            {
                transform.position = playerPos; //プレイヤーの位置を更新
            }

        }
        else
        {
            animator.SetFloat("speed", 0.0f);
        }


        
       



    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("VendingMachine"))
        {
            isFrontVendingMachine = true;  // 自販機が近くにあることを確認
            vendingMachine = other.gameObject;  // 自販機の参照を保持
            Debug.Log("自販機の前に来た");
        }
    }

    // 自販機から離れたときにフラグをリセット
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("VendingMachine"))
        {
            isFrontVendingMachine = false;
            Debug.Log("自販機から離れた");
        }
    }

}
