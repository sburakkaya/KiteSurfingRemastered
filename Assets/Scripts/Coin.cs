using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Animator _animator;
    private Money _money;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _money = FindObjectOfType<Money>();
    }

    public void Collected()
    {
        _animator.SetBool("collect",true);
    }

    public void PluseMoney()
    {
        _money.MoneyPlus();
    }
    
}
