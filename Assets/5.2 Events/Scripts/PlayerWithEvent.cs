using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithEvent : MonoBehaviour
{
	public Animator ani;
	public GameObject FireballPrefab;

	private float walkSpeed = 1f;

	private void Update()
	{
		if (Input.GetAxisRaw("Horizontal") > 0f)
		{
			transform.position += new Vector3(walkSpeed * Time.deltaTime, 0f);
			ani.SetBool("Walking", true);
		}
		else
		{
			ani.SetBool("Walking", false);
		}
	}

	public void AnimationEvent_ShootFireball()
	{
		Debug.Log("Shooting fireball!");
		Instantiate(FireballPrefab, transform.position, Quaternion.identity);
	}

	public void AnimationEvent_Idle()
	{
		Debug.Log("Idle");
	}
}
