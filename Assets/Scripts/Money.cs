using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI _openingMoneyTmp;
    public TextMeshProUGUI _ingameMoneyTmp;
    public Animator _ingameMoneyAnim;

    private void Start()
    {
        StartCoroutine(WriteMoney());
    }

    public void MoneyPlus()
    {
        PlayerPrefs.SetFloat("money",PlayerPrefs.GetFloat("money")+25);
        StartCoroutine(WriteMoney());
    }

    IEnumerator WriteMoney()
    {
        _openingMoneyTmp.text = PlayerPrefs.GetFloat("money").ToString("F0");
        _ingameMoneyTmp.text = PlayerPrefs.GetFloat("money").ToString("F0");
        _ingameMoneyAnim.SetBool("collected",true);
        yield return new WaitForSeconds(0.2f);
        _ingameMoneyAnim.SetBool("collected",false);
    }
}
