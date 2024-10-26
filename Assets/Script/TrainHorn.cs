using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainHorn : MonoBehaviour
{

	AudioSource horn;

	private void Start()
	{
		horn = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 3)
		{
			horn.Play();
		}
	}
}
