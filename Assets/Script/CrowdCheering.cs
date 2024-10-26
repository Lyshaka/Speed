using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdCheering : MonoBehaviour
{
	[Header("Audio")]
	AudioSource[] crowds;
	public float fadeInTime = 1f;
	public float fadeOutTime = 1f;

	[Header("Movement")]
	public Material crowdMat;
	public float moveSpeed = 1f;
	private float currentMovement;
	private int direction = 1;


	// Start is called before the first frame update
	void Start()
	{
		crowds = GetComponentsInChildren<AudioSource>();
		foreach (AudioSource crowd in crowds)
		{
			StartCoroutine(StartSoundRandomDelay(crowd));
		}
	}

	private void Update()
	{
		//crowdMat.mainTextureOffset.x += Time.deltaTime * moveSpeed;
		if (crowdMat.mainTextureOffset.y > 0.1f)
			direction = -1;
		if (crowdMat.mainTextureOffset.y < -0.1f)
			direction = 1;
		crowdMat.mainTextureOffset = new Vector2(0.0f, crowdMat.mainTextureOffset.y + moveSpeed * Time.deltaTime * direction);
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
