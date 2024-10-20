using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
	public TheSphere player;
	public AnimationCurve curve;
	public float volumeMultiplier = 0.4f;

	AudioSource audioSource;

	// Start is called before the first frame update
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		audioSource.volume = curve.Evaluate(player.CurrentSpeed / player.MaxSpeed) * volumeMultiplier + 0.01f;
	}
}
