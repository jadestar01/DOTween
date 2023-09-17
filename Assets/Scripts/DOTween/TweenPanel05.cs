using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TweenPanel05 : TweenPanel
{
    public Image image;
    public TextMeshProUGUI text;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(image.DOFade(0, 1f))
        .Join(text.DOFade(0, 1f))
        .Append(image.DOFade(1, 1f))
        .Join(text.DOFade(1, 1f))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();

        image.DOFade(1, 0);
        text.DOFade(1, 0);
    }
}
