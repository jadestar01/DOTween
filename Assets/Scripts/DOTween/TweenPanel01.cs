using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class TweenPanel01 : TweenPanel
{
    public Image backImage;
    public Image filler;
    public TextMeshProUGUI timer;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .AppendCallback(() => backImage.enabled = true)
        .AppendCallback(() => timer.gameObject.SetActive(true))
        .AppendCallback(() => timer.text = "5.0")
        .AppendCallback(() => filler.fillAmount = 0)
        .Append(DOTween.To(() => 5f, x => timer.text = x.ToString("F1"), 0f, 5))
        .Join(DOTween.To(() => 0.0f, x => filler.fillAmount = x, 1, 5))
        .AppendCallback(() => timer.gameObject.SetActive(false))
        .AppendCallback(() => backImage.enabled = false)
        .Append(filler.GetComponent<RectTransform>().DOScale(1.3f, 0.1f).SetEase(Ease.OutSine))
        .Append(filler.GetComponent<RectTransform>().DOScale(1, 0.1f).SetEase(Ease.OutSine))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        timer.text = "5.0";
        filler.fillAmount = 0;
    }
}
