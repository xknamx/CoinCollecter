using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;    //�ړ����x
    [SerializeField] private Animator animator;     //Animator�̃Z�b�g
    Vector2 PlayerPos; //�v���C���[�̈ʒu
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

    //�v���C���[�̈ړ�����
    void PlayerMoving()
    {
        float horizontal = Input.GetAxis("Horizontal"); // �����܂���AD�L�[���͂����o
        float vertical = Input.GetAxis("Vertical");     // �����܂���WS�L�[���͂����o

        if (vertical < 0) //�����͂��ꂽ�Ƃ�
        {
            animator.SetTrigger("front");�@//��O������
        }

        if (vertical > 0)�@//����͂��ꂽ�Ƃ�
        {
            animator.SetTrigger("behind");�@//��������
        }

      

        if (horizontal != 0)
        {

            if (horizontal > 0) //�����͂��ꂽ�Ƃ�
            {
                spriteRenderer.flipX = false; //��������
            }
            else if (horizontal < 0) //�E���͂��ꂽ�Ƃ�
            {
                spriteRenderer.flipX = true; //�E������
            }
            PlayerPos.x += horizontal * speed;
            animator.SetFloat("speed", 1.0f);

        }
        else
        {
            animator.SetFloat("speed", 0.0f);
        }

        transform.position = PlayerPos; //�v���C���[�̈ʒu���X�V

        

    }



    //���̋@��T���ۂ̏���
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("VendingMachine"))
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetInteger("direction", 3); //���̋@�̂ق�������
                Debug.Log("���̋@���N���b�N���܂���");
                //���̋@��T��������ǉ�
            }
        }
    }
}
