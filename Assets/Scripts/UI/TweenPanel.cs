using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract class TweenPanel : MonoBehaviour
{
    public Sequence seq;

    public abstract void StartTween();

    public abstract void ResetTween();
}

/*
    public override void StartTween()
    {
        Debug.Log("");
    }

    public override void ResetTween()
    {
        Debug.Log("");
    }
*/