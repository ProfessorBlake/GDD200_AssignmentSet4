using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
	public float Speed;

    void Update()
    {
		transform.position += new Vector3(Speed * Time.deltaTime, 0, 0f);
		transform.position = new Vector3(transform.position.x, Mathf.Sin(transform.position.x) * 0.1f, 0);

		if (transform.position.x > 20f)
			Destroy(gameObject);
    }
}
