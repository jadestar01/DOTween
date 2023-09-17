using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseoverEvent : MonoBehaviour
{
    public bool isSelected = false;

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
        if (isSelected)
            return;

        text.color = targetColor;
    }

    public void OnPointerExit()
    {
        if (isSelected)
            return;
        text.color = defaultColor;
    }

    public void OnClick()
    {
        if (isSelected)
            return;

        Manager.Instance.SetPanelIndex(index);
    }

    public void Select()
    {
        isSelected = true;
        text.color = targetColor;
    }

    public void UnSelect()
    {
        isSelected = false;
        text.color = defaultColor;
    }
}
