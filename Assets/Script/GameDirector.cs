using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject SightGage;

    void Start()
    {
        this.SightGage = GameObject.Find("SightGage");
    }

    public void IncreaceLineOfSight()
    {
        SightGage.GetComponent<Image>().fillAmount += 0.1f;
    }
}
