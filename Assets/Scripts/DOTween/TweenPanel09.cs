using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TweenPanel09 : TweenPanel
{
    public List<RectTransform> rects = new List<RectTransform>();

    public override void StartTween()
    {
        seq = DOTween.Sequence();

        for (int i = 0; i < rects.Count; i++)
        {
            int a = i;
            seq.AppendCallback(() =>
            {
                Sequence seq01 = DOTween.Sequence()
                .AppendCallback(() => rects[a].DOAnchorPos(new Vector3(0, 750, 0), 0.5f).SetRelative(true).SetEase(Ease.InSine))
                .AppendInterval(0.5f)
                .AppendCallback(() => rects[a].DOAnchorPos(new Vector3(0, -750, 0), 0.5f).SetRelative(true).SetEase(Ease.OutSine))
                .Play();
            });

            seq.AppendInterval(0.15f);
        }

        seq.Play();
    }

    public override void ResetTween()
    {
        seq.Pause();

        for (int i = 0; i < rects.Count; i++)
        {
            int a = i;
            rects[a].DOAnchorPos(new Vector3(rects[a].anchoredPosition.x, -650, 0), 0f);
        }
    }
}

