using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private static Manager instance;
    public static Manager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public List<GameObject> tweenPanels = new List<GameObject>();
    public int index = 0;

    public void SetPanelIndex(int num)
    {
        switch (num)
        {
            case -1:
                TweenStart();
                break;
            case -2:
                TweenReset();
                break;
            default:
                TweenReset(index);
                index = num;
                SetData();
                break;
        }
    }

    public void SetData()
    {
        if (tweenPanels.Count <= index)
            return;

        for (int i = 0; i < tweenPanels.Count; i++)
        {
            if (i == index)
                tweenPanels[i].SetActive(true);
            else
                tweenPanels[i].SetActive(false);
        }
    }

    public void TweenStart()
    {
        if (tweenPanels.Count <= index)
            return;

        tweenPanels[index].transform.GetChild(0).GetComponent<TweenPanel>().StartTween();
    }

    public void TweenReset()
    {
        if (tweenPanels.Count <= index)
            return;

        tweenPanels[index].transform.GetChild(0).GetComponent<TweenPanel>().ResetTween();
    }

    public void TweenReset(int num)
    {
        if (tweenPanels.Count <= num)
            return;

        tweenPanels[num].transform.GetChild(0).GetComponent<TweenPanel>().ResetTween();
    }
}
