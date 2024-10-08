using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSphere : MonoBehaviour
{
	// Start is called before the first frame update
	private Rigidbody Rigidbody;
	public float MaxSpeed = 50;
	public float BrakeSpeed { get; private set; }
    public float Acceleration { get; private set; }
	public float Deceleration { get; private set; }
    public float CurrentSpeed { get; private set; } = 0f;
	public float RotateSpeed = 90f;
	private float prevSpeed = 0f;
    public float currentAcceleration { get; private set; }
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

		currentAcceleration = CurrentSpeed - prevSpeed;
		prevSpeed = CurrentSpeed;
        
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
