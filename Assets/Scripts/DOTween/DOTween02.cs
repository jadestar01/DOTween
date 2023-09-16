using DG.Tweening;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTween02 : MonoBehaviour
{
    public Ease ease = Ease.Linear;

    [Button]
    public void Tweening()
    {
        transform.DOMove(new Vector2(16, 0), 10).SetEase(ease).SetRelative(true);
    }

    public void Start()
    {
        Tweening();
    }
}
