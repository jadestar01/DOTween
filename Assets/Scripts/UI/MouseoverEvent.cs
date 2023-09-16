using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseoverEvent : MonoBehaviour
{
    public int index;

    TextMeshProUGUI text;

    public Color defaultColor;
    public Color targetColor;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.color = defaultColor;
    }

    public void OnPointerEnter()
    {
        text.color = targetColor;
    }

    public void OnPointerExit()
    {
        text.color = defaultColor;
    }

    public void OnClick()
    {
        Manager.Instance.SetPanelIndex(index);
    }
}
