using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AhsapController : MonoBehaviour
{
	Animator _animator;

	public bool isRight = false;
	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}
	public void RightButton()
	{
		_animator.SetTrigger("Right");
		isRight = true;
		Debug.Log("Button");
	}
	public void LeftButton()
	{
		Debug.Log("Button");

		_animator.SetTrigger("Left");
		isRight = false;
	}
}
