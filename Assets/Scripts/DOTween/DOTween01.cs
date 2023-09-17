using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;

public class DOTween01 : MonoBehaviour
{
    public int a = 0;
    public float b = 0;
    public string c = "";

    public TextMeshProUGUI a_text;

    Tweener abc;

    private void Start()
    {
        abc = a_text.DOText("abcdefg", 0.3f)
            .OnPlay(() => Debug.Log("Played"))
            .OnStart(() => Debug.Log("Started"))
            .SetAutoKill(false);

        StartCoroutine(Cor());
    }

    IEnumerator Cor()
    {
        yield return new WaitForSeconds(1f);
        abc.Play();
    }

    [Button]
    public void TOTween()
    {
        //DOTween.To(() => a_text.text, x => a_text.text = x, "abcdef", 2f);
        DOTween.To(() => 0, x => a_text.text = x.ToString("F2"), 100f, 2f);
        //DOTween.TO(() => 시작값, 변수 => 변경할식, 나중값, 시간);
    }
}