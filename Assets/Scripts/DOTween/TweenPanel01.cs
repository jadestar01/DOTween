using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class TweenPanel01 : TweenPanel
{
    public Image filler;
    public TextMeshProUGUI timer;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .AppendCallback(() => timer.text = "5.0")
        .AppendCallback(() => filler.fillAmount = 0)
        .Append(DOTween.To(() => 5f, x => timer.text = x.ToString("F1"), 0f, 5))
        .Join(DOTween.To(() => 0.0f, x => filler.fillAmount = x, 1, 5))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        timer.text = "5.0";
        filler.fillAmount = 0;
    }
}
