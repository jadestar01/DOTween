using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TweenPanel00 : TweenPanel
{
    public TextMeshProUGUI timer;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .AppendCallback(() => timer.text = "0.0")
        .Append(DOTween.To(() => 0.0f, x => timer.text = x.ToString("F1"), 10f, 10))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        timer.text = "0.0";
    }
}
