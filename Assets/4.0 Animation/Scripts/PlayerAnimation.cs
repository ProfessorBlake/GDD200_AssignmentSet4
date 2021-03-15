using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator ani;

	private float walkSpeed = 2f;

	private void Update()
	{
		if(Input.GetAxisRaw("Horizontal") > 0f)
		{
			transform.position += new Vector3(walkSpeed * Time.deltaTime, 0f);
			ani.SetBool("Walking", true);
		}
		else
		{
			ani.SetBool("Walking", false);
		}
	}
}
