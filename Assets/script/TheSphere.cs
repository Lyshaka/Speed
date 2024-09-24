using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSphere : MonoBehaviour
{
	// Start is called before the first frame update
	private Rigidbody Rigidbody;
	public float MaxSpeed = 50;
	float BrakeSpeed;
	float Acceleration ;
	float Deceleration;
	private float CurrentSpeed = 0;
	public float RotateSpeed = 90;
	Camera playercam;

	public ParticleSystem ps_friction;
	public AnimationCurve ac_friction;

	void Start()
	{
		Rigidbody = GetComponent<Rigidbody>();
		Deceleration = MaxSpeed / 3;
		BrakeSpeed = MaxSpeed / 1.5f;
		Acceleration = MaxSpeed ;
		playercam = Camera.main;
	}

   
	void Update()
	{

		Move();
		var emission = ps_friction.emission;
		emission.rateOverTime = ac_friction.Evaluate((CurrentSpeed / MaxSpeed)) * 50f;
	}
	private void Move()
	{
		Vector3 Jump = Vector3.zero;
		if (Input.GetKey(KeyCode.S))
		{
			CurrentSpeed -= BrakeSpeed * Time.deltaTime;
			if (CurrentSpeed < 0)
			{
				CurrentSpeed = 0;
			}
		}
		else if (Input.GetKey(KeyCode.W))
		{
			CurrentSpeed += Acceleration * Time.deltaTime;

			if (CurrentSpeed > MaxSpeed)
			{
				CurrentSpeed = MaxSpeed;
			}
		}
		else
		{
			if (CurrentSpeed > 0)
			{
				CurrentSpeed -= Deceleration * Time.deltaTime;
				if (CurrentSpeed < 0)
				{
					CurrentSpeed = 0;
				}
			}
		}


		//Vector3 projedcam = Vector3.ProjectOnPlane(playercam.transform.forward, Vector3.up);
		Vector3 finalVelo = playercam.transform.forward;

		Rigidbody.velocity = finalVelo * CurrentSpeed;
	}
}
