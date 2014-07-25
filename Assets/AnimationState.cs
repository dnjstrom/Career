using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[RequireComponent(typeof(Animator))]
public class AnimationState : MonoBehaviour 
{
	private Animator _animator;
    private Action _callbackAction;
	private bool _stateReset;

	void Awake()
	{
		_animator = GetComponent<Animator>();
	}

	public void SetTrigger(string trigger, Action callback = null)
	{
		_animator.SetTrigger(trigger);
		_callbackAction = callback;
	}

	protected void Update()
	{
		if (_animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1f && !_stateReset)
			_stateReset = true;

		if (_animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1f && _stateReset)
		{
			_stateReset = false;

			if (_callbackAction != null)
			{
				_callbackAction();
				_callbackAction = null;
			}
		}
	}
}
