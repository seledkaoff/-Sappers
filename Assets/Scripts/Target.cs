using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]

public class Target : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
         
    }

    public void Hit()
    {
        _animator.Play("Hit");
        
    }

    public void Show()
    {
        _animator.Play("Show");
       
    }
}
