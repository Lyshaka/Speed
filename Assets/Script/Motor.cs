using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{
	public TheSphere player;
	public AnimationCurve curve;
	public float volumeMultiplier = 0.4f;
	public float rotationSpeed = 1f;
	public float maxRotation = 1f;

	private float currentRotationSpeed = 0f;

	AudioSource audioSource;

	// Start is called before the first frame update
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
		{
			currentRotationSpeed += Time.deltaTime * rotationSpeed;
			currentRotationSpeed = Mathf.Clamp(currentRotationSpeed, 0f, maxRotation);
		}
		else
		{
			currentRotationSpeed -= Time.deltaTime * rotationSpeed;
			currentRotationSpeed = Mathf.Clamp(currentRotationSpeed, 0f, maxRotation);
		}

		audioSource.pitch = 1f + curve.Evaluate(player.CurrentSpeed / player.MaxSpeed) * volumeMultiplier - currentRotationSpeed;
	}
}
