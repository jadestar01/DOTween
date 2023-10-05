using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenPanel13 : TweenPanel
{
    public RectTransform l_door;
    public RectTransform r_door;
    public RectTransform button;

    bool isSequencing = false;
    bool isOpen = false;

    public override void StartTween()
    {
        seq = DOTween.Sequence();
    }

    public void OnClick()
    {
        if (isSequencing)
            return;

        if (!isOpen)
        {
            Sequence seq01 = DOTween.Sequence()
            .AppendCallback(() => isSequencing = true)
            .Append(button.DOScale(new Vector3(2, 2, 1), 0.25f).SetEase(Ease.InCubic))
            .Append(l_door.DOAnchorPos(new Vector3(-750, 0, 0), 0.3f).SetEase(Ease.InSine))
            .Join(r_door.DOAnchorPos(new Vector3(750, 0, 0), 0.3f).SetEase(Ease.InSine))
            .Play()
            .OnComplete(() =>
            {
                isSequencing = false;
                isOpen = true;
            });
        }
        else
        {
            Sequence seq01 = DOTween.Sequence()
            .AppendCallback(() => isSequencing = true)
            .Append(button.DOScale(new Vector3(1, 1, 1), 0.25f).SetEase(Ease.OutCubic))
            .Append(l_door.DOAnchorPos(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutSine))
            .Join(r_door.DOAnchorPos(new Vector3(0, 0, 0), 0.3f).SetEase(Ease.OutSine))
            .Play()
            .OnComplete(() =>
            {
                isSequencing = false;
                isOpen = false;
            });
        }
    }

    public override void ResetTween()
    {
        seq.Pause();
    }
}