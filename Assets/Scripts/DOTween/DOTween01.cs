using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;

public class DOTween01 : MonoBehaviour
{
    public Transform a;

    [Button]
    public void Jump()
    {
        Sequence seq2 = DOTween.Sequence()
        .AppendCallback(() => Debug.Log("안녕티비 ㅋㅋ"))
        .AppendInterval(1f)
        .AppendCallback(() => Debug.Log("우헤헤!!"));

        Sequence seq = DOTween.Sequence()

        .Append(a.DOMoveX(0, 3))
        .Join(a.DOMoveY(4, 4).SetEase(Ease.OutQuad))

        .Append(a.DOMoveX(8, 3))
        .Join(a.DOMoveY(-4, 2).SetEase(Ease.InQuad))

        .Play();
    }
}