using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdCheering : MonoBehaviour
{
	AudioSource[] crowds;
	public float fadeInTime = 1f;
	public float fadeOutTime = 1f;

	// Start is called before the first frame update
	void Start()
	{
		crowds = GetComponentsInChildren<AudioSource>();
		foreach (AudioSource crowd in crowds)
		{
			StartCoroutine(StartSoundRandomDelay(crowd));
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 3)
		{
			StartCoroutine(ActivateSound());
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.layer == 3)
		{
			StartCoroutine(DeactivateSound());
		}
	}

	IEnumerator StartSoundRandomDelay(AudioSource a)
	{
		yield return new WaitForSeconds(Random.Range(0f, 1f));
		a.Play();
	}

	IEnumerator DeactivateSound()
	{
		float elapsedTime = 0.0f;

		foreach (AudioSource crowd in crowds)
			crowd.volume = 0.0f;
		while (elapsedTime < fadeOutTime)
		{
			foreach (AudioSource crowd in crowds)
				crowd.volume = 1.0f - (elapsedTime / fadeOutTime);
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		foreach (AudioSource crowd in crowds)
			crowd.volume = 0.0f;
	}

	IEnumerator ActivateSound()
	{
		float elapsedTime = 0.0f;

		foreach (AudioSource crowd in crowds)
			crowd.volume = 0.0f;
		while (elapsedTime < fadeInTime)
		{
			foreach (AudioSource crowd in crowds)
				crowd.volume = elapsedTime / fadeInTime;
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		foreach (AudioSource crowd in crowds)
			crowd.volume = 1.0f;
	}
}
