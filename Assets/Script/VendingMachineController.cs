using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class VendingMachineController : MonoBehaviour
{
    [SerializeField] GameObject searchPanel;
    //UnityEvent clickedVendingMachine;

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
        searchPanel.GetComponent<SearchPanel>().ClicedSearchPanel();
    }

    
}
