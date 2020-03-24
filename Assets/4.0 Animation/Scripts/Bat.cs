using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
	public Animator BatAnimator;

	private void Update()
	{
		float moveDir = Input.GetAxis("Horizontal"); //Set in Edit -> Project Settings -> Input
		if(moveDir != 0f)
		{
			transform.position += new Vector3(moveDir * Time.deltaTime, 0f, 0f);
			BatAnimator.SetInteger("State", 1);
		}
		else
		{
			BatAnimator.SetInteger("State", 0);
		}

		if(Input.GetKey(KeyCode.Space))
		{
			BatAnimator.SetInteger("State", 2);
		}
	}
}
