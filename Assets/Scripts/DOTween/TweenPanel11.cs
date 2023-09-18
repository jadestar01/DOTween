using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class TweenPanel11 : TweenPanel
{
    public RectTransform eye;
    public RectTransform top;
    public RectTransform bottom;

    public Tweener eyeTween;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(top.DOAnchorPos(new Vector3(0, 0, 0), 0.3f))
        .Join(bottom.DOAnchorPos(new Vector3(0, -100, 0), 0.3f))
        .AppendInterval(0.2f)
        .Append(top.DOAnchorPos(new Vector3(0, 250, 0), 0.3f))
        .Join(bottom.DOAnchorPos(new Vector3(0, -250, 0), 0.3f))
        .AppendInterval(3f)
        .SetLoops(-1).Play();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log(Input.mousePosition);

        float point = Mathf.Abs(Input.mousePosition.x - 750) > 250 ? Input.mousePosition.x - 750 > 0 ? 250 : -250 : Input.mousePosition.x - 750;

        eye.DOAnchorPosX(point, 0.3f).SetEase(Ease.OutQuad);
    }

    public override void ResetTween()
    {
        seq.Pause();

        eye.DOAnchorPos(new Vector3(0, 0, 0), 0);
        top.DOAnchorPos(new Vector3(0, 250, 0), 0);
        bottom.DOAnchorPos(new Vector3(0, -250, 0), 0);
    }
}
