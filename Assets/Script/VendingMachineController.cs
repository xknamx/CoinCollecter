using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class VendingMachineController : MonoBehaviour
{
    [SerializeField] GameObject searchPanel;
    //UnityEvent clickedVendingMachine;

    [SerializeField] PlayerController playerController;


    private bool isSearched = false; //すでに探された自販機かどうかのフラグ

    [SerializeField]TextBoxController textBox;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickedVendingMachineOnMap()
    {
        Debug.Log("自販機がクリックされた");
        if (!isSearched)
        {
            isSearched = true;
            playerController.SearchAnimation();
            StartCoroutine(ShowUIPanel());
            GameManager.Instance.caughtVendingMachinesCount++;
        }
        else 
        {
            textBox.ShowTextBox("もう探した自販機だ");
        }
    }


    IEnumerator ShowUIPanel()
    {
        yield return new WaitForSeconds(0.6f);
        searchPanel.GetComponent<SearchPanel>().ShowSearchPanel();
    }
    
}
