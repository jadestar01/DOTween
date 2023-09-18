using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class TweenPanel10 : TweenPanel
{
    public RectTransform rect01;
    public RectTransform rect02;

    public override void StartTween()
    {
        seq = DOTween.Sequence()

        .AppendCallback(() =>
        {
            rect01.DORotate(new Vector3(0, 0, 0), 0);
            rect02.DORotate(new Vector3(0, 0, 0), 0);
        })

        .Append(rect01.DORotate(new Vector3(90, 0, 0), 2))
        .Join(rect02.DORotate(new Vector3(0, 90, 0), 2))

        .AppendCallback(() => rect02.DORotate(new Vector3(0, 270, 0), 0))

        .Append(rect01.DORotate(new Vector3(180, 0, 0), 2))
        .Join(rect02.DORotate(new Vector3(0, 360, 0), 2))

        .SetLoops(-1).Play();
    }

    public override void ResetTween()
    {
        seq.Pause();

        rect01.DORotate(new Vector3(0, 0, 0), 0);
        rect02.DORotate(new Vector3(0, 0, 0), 0);
    }
}

