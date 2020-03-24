using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
	public float Speed;

    void Update()
    {
		transform.position += new Vector3(0f, Speed * Time.deltaTime, 0f);

		if (transform.position.y < -10f)
			Destroy(gameObject);
    }
}
