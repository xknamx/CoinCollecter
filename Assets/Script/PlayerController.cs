using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;    //移動速度
    [SerializeField] private Animator animator;     //Animatorのセット
    Vector2 PlayerPos; //プレイヤーの位置
    float horizontal;
    SpriteRenderer spriteRenderer;
   //  bool isWalking = false;



    private void Start()
    {
        animator = GetComponent<Animator>();
        PlayerPos = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        PlayerMoving();

    }

    //プレイヤーの移動処理
    void PlayerMoving()
    {
        float horizontal = Input.GetAxis("Horizontal"); // ←→またはADキー入力を検出
        float vertical = Input.GetAxis("Vertical");     // ↑↓またはWSキー入力を検出

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
            PlayerPos.x += horizontal * speed ;
            animator.SetFloat("speed", 1.0f);
            
        }
        else
        {
            animator.SetFloat("speed", 0.0f);
        }

      
        transform.position = PlayerPos; //プレイヤーの位置を更新

        ////前後方向
        //if (vertical > 0)
        //{
        //    animator.SetInteger("direction", 3);//後ろを向く
        //}

        //if (vertical < 0) //前を向く
        //{
        //    animator.SetInteger("direction", 0);//正面を向く
        //}


        // 入力がある場合はアニメーションを再生
        //if (horizontal != 0 || vertical != 0)
        //{
        //    animator.SetFloat("MoveSpeed", 1f); // アニメーション再生
        //}
        //else
        //{
        //    animator.SetFloat("MoveSpeed", 0f); // アニメーション停止
        //}
        //PlayerPos.x += horizontal * speed * Time.deltaTime;
        //transform.position = PlayerPos; //プレイヤーの位置を更新
    }



    //自販機を探す際の処理
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("VendingMachine"))
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetInteger("direction", 3); //自販機のほうを向く
                Debug.Log("自販機をクリックしました");
                //自販機を探す処理を追加
            }
        }
    }
}
