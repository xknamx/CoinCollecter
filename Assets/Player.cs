using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("VendingMachine"))
        {
          
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("���̋@���N���b�N���܂���");
                //���̋@��T��������ǉ�
            }
        }
           
    }
}
