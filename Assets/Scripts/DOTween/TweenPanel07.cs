using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TweenPanel07 : TweenPanel
{
    public Image teemo;
    public RectTransform unit;
    public Image bar;
    public RectTransform arrow;

    public float maxHp = 100f;
    public float curHp = 100f;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(teemo.DOFade(1, 0.3f))
        .AppendInterval(0.3f)
        .Append(unit.DOAnchorPos(new Vector3(0, 300, 0), 0.5f)).SetEase(Ease.OutQuad)
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();
        maxHp = 100;
        curHp = 100;
        teemo.DOFade(0, 0f);

        bar.fillAmount = 1;
        unit.DOAnchorPos(new Vector3(0, 500, 0), 0f);
    }

    public void GetDamaged()
    {
        Sequence damageSeq = DOTween.Sequence()
        .Append(arrow.DOAnchorPos(new Vector3(0, 100, 0), 0.2f).SetEase(Ease.InQuad))
        .Append(arrow.DOAnchorPos(new Vector3(0, -420, 0), 0f))
        .Append(teemo.GetComponent<RectTransform>().DOShakeRotation(0.1f))
        .Join(DOTween.To(() => (float)bar.fillAmount, x => bar.fillAmount = x, ((float)(curHp - 25) / (float)(maxHp)), 0.5f).SetEase(Ease.Linear))
        .AppendCallback(() =>
        {
            curHp -= 25;

            if (curHp <= 0)
            {
                Sequence killTeemo = DOTween.Sequence()
                .Append(teemo.DOFade(0, 0.3f))
                .Append(unit.DOAnchorPos(new Vector3(0, 500, 0), 0.5f)).SetEase(Ease.InQuad)
                .Play();
            }
        })
        .Play();
    }
}
