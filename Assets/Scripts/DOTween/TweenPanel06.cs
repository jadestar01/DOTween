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
        .Append(text01.DOText("* ��! ����!", 0.3f))
        .AppendInterval(0.1f)
        .Append(text02.DOText("* ������� �ƽô±���! Ȥ�� �𸣽ôºе鿡 ���� �����ص帳�ϴ� ����� ��������� ������ ������Ʈ�� ���쿣���� ���������� ��.¥.��.��.��.��.��.��.�� ������ ���δ� ȸ���ϰ� ���ǰ� 92�ε� ������ ������ 1�ʴ� 60�� �ٴµ��ٰ� �������� �߰��� �پ��ֽ��ϴ�.", 10f))
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