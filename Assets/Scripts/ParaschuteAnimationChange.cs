using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaschuteAnimationChange : MonoBehaviour
{

    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void ChangeAnim()
    {
        _animator.SetBool("trans",true);
    }
}
