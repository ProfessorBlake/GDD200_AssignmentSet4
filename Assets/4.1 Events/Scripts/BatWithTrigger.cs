using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatWithTrigger : MonoBehaviour
{
	public Animator BatAnimator;
	public GameObject FireballPrefab;

	private void Update()
	{
		float moveDir = Input.GetAxis("Horizontal");
		if (moveDir != 0f)
		{
			transform.position += new Vector3(moveDir * Time.deltaTime * 2f, 0f, 0f);
			BatAnimator.SetInteger("State", 1);
		}
		else
		{
			BatAnimator.SetInteger("State", 0);
		}
	}

	public void AnimationEvent_ShootFireball()
	{
		//The animation can trigger a public function in a script on the same game object as the animator component.
		Debug.Log("Shooting fireball!");
		Instantiate(FireballPrefab, transform.position, Quaternion.identity);
	}

	public void AnimationEvent_Idle()
	{
		Debug.Log("Idle");
	}
}
