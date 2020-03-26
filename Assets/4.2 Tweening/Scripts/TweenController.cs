using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenController : MonoBehaviour
{
	public Animator Animator;

	private void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			Animator.SetInteger("state", 1);
		}
		else if (Input.GetKey(KeyCode.UpArrow))
		{
			Animator.SetInteger("state", 2);
		}
		else
		{
			Animator.SetInteger("state", 0);
		}
	}
}
