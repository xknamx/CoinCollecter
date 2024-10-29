using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CoinAnimator : MonoBehaviour
{
    [SerializeField] private Vector2 targetPosition = new Vector2(-450f, 250f); // 吸い込まれる最終位置
    [SerializeField] private float initialDropAmount = -60f; // 最初の落下量
    [SerializeField] private float dropDuration = 0.5f; // 最初の落下時間
    [SerializeField] private float moveDuration = 1f; // 吸い込まれる移動時間

    private RectTransform rectTransform;

    void Start()
    {


        rectTransform = GetComponent<RectTransform>();

        // アニメーションのシーケンスを設定
        Sequence coinSequence = DOTween.Sequence();

        // コインが少し下に落ちる動き
        coinSequence.Append(rectTransform.DOAnchorPosY(rectTransform.anchoredPosition.y + initialDropAmount, dropDuration).SetEase(Ease.OutBounce));

        // 吸い込まれるように左上に移動し、スケールダウン
        coinSequence.Append(rectTransform.DOAnchorPos(targetPosition, moveDuration).SetEase(Ease.InQuad))
                    .Join(rectTransform.DOScale(0f, moveDuration).SetEase(Ease.InQuad));

        // シーケンス再生
        coinSequence.Play();



    }

    // Update is called once per frame
    void Update()
    {

    }
}
