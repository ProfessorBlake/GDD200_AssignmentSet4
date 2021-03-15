using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
	public float Speed;

    void Update()
    {
		transform.position += new Vector3(Speed * Time.deltaTime, 0f, 0f);

		if (transform.position.x > 20f)
			Destroy(gameObject);
    }
}
