using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchPanel : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] private SearchButton searchButton; // SearchButtonの参照を追加


    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowSearchPanel()
    {
        gameObject.SetActive(true);
       // StartCoroutine(FadeinAnimation());

        // SearchButtonのリセット処理を呼び出す
        searchButton.ResetButton();
    }

   

    //IEnumerator FadeinAnimation()
    //{
    //    yield return new WaitForSeconds(1f);
    //   // animator.SetTrigger("PlayFadeinAnimation");

    //}

    public void CloseSearchPanel()
    {
        gameObject.SetActive(false );
    }
}
