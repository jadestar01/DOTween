using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TweenPanel06 : TweenPanel
{
    public Image sans;
    public Image panel01;
    public Image panel02;
    public TextMeshProUGUI text01;
    public TextMeshProUGUI text02;

    public override void StartTween()
    {
        seq = DOTween.Sequence()
        .Append(sans.DOFade(1, 0.3f))
        .AppendInterval(0.1f)
        .Append(panel01.DOFade(1, 0.3f))
        .Join(panel02.DOFade(1, 0.3f))
        .AppendInterval(0.1f)
        .Append(text01.DOText("* 와! 샌즈!", 0.3f))
        .AppendInterval(0.1f)
        .Append(text02.DOText("* 언더테일 아시는구나! 혹시 모르시는분들에 대해 설명해드립니다 샌즈랑 언더테일의 세가지 엔딩루트중 몰살엔딩의 최종보스로 진.짜.겁.나.어.렵.습.니.다 공격은 전부다 회피하고 만피가 92인데 샌즈의 공격은 1초당 60이 다는데다가 독뎀까지 추가로 붙어있습니다.", 10f))
        .Play();
    }

    public override void ResetTween()
    {
        seq.Pause();

        sans.DOFade(0, 0);
        panel01.DOFade(0, 0);
        panel02.DOFade(0, 0);
        text01.text = "";
        text02.text = "";
    }
}