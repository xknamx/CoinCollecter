using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachineController : MonoBehaviour
{
    [SerializeField] GameObject searchPanel;
    void Start()
    {
        searchPanel = GameObject.Find("SearchPanel");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickedVendingMachineOnMap()
    {
        Debug.Log("自販機がクリックされた");
        searchPanel.SetActive(true);
    }
}
