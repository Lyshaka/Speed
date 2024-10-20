using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
	[Header("Specs")]
	public float speed = 45f;

	[Header("Technical")]
	public GameObject wheel;
	public GameObject[] cabins;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		wheel.transform.Rotate(new Vector3(0f, -speed * Time.deltaTime, 0f));
		foreach (GameObject cabin in cabins)
		{
			cabin.transform.Rotate(new Vector3(0f, speed * Time.deltaTime, 0f));
		}
	}
}
