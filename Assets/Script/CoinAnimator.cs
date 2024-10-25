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
        // RectTransform rectTransform = GetComponent<RectTransform>();
        //// RectTransform collectTransform. = new Vector2(-450f, 250f);

        // RectTransform spawnrectTransform = GetComponent<RectTransform>();

        // rectTransform.anchoredPosition = new Vector2(rectTransform.position.x, rectTransform.position.y - 60f); //出現位置より60上にずらす

        // rectTransform.DOPunchAnchorPos(rectTransform.anchoredPosition, 1f).SetEase(Ease.OutBounce).OnComplete(() =>
        // {
        //     rectTransform.DOAnchorPos(rectTransform.anchoredPosition = new Vector2(-450, 250), 1f);
        //     rectTransform.DOScale(0f, 1f);

        // });
        //     // OutBonceでスポーン位置に落とす
        //     //InExpoで左上の一点に集約と同時にスケールをにしていく


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
