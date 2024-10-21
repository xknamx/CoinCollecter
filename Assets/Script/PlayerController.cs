using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;    //移動速度
    [SerializeField] private Animator animator;     //Animatorのセット
    Vector2 PlayerPos; //プレイヤーの位置
    SpriteRenderer spriteRenderer;


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
            PlayerPos.x += horizontal * speed;
            animator.SetFloat("speed", 1.0f);

        }
        else
        {
            animator.SetFloat("speed", 0.0f);
        }

        transform.position = PlayerPos; //プレイヤーの位置を更新

        

    }



    //自販機を探す際の処理
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("自販機の前にいます。");
        if (other.CompareTag("VendingMachine"))
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("behind"); //奥を向く 
                other.GetComponent<VendingMachineController>().ClickedVendingMachineOnMap();
            }
        }
    }
}
