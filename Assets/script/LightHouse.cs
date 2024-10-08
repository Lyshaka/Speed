using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouse : MonoBehaviour
{
	public float speed = 10f;

	void Update()
	{
		transform.eulerAngles -= new Vector3(0f, speed * Time.deltaTime, 0f);     
	}
}
