using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchPanel : MonoBehaviour
{
    [SerializeField] Animation animation = new Animation();


    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClicedSearchPanel()
    {
        StartCoroutine(ShowSearchPanel());
    }

     IEnumerator ShowSearchPanel()
    {
        yield return new WaitForSeconds(0.8f);
        gameObject.SetActive(true);
        StartCoroutine(FadeinAnimation());

    }

    IEnumerator FadeinAnimation()
    {
        yield return new WaitForSeconds(1f);
        animation.Play();

    }

    public void CloseSearchPanel()
    {
        gameObject.SetActive(false );
    }
}
