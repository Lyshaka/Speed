using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Camfollow : MonoBehaviour
{
	// Start is called before the first frame update
	public Vector3 Offset = Vector3.zero;
	public Transform Target;
	Vector3 Velocity =  Vector3.zero;
	float RotateSpeed = 90;
	public Vector3 VisualRotation = new Vector3(0,0,0);
	float PrevMp = 0;

	[Header("FOV")]
	public int minFov = 85;
	public int maxFov = 105;

	[Header("Camera Position")]
	public float cameraBackPull = 6.0f;
	public float cameraFrontPull = 3.0f;
	public float TimeSmooth = 0.5f;
	private Vector3 cameraTargetMinPosition;
	private Vector3 cameraTargetMaxPosition;
	private Vector3 cameraOriginalPosition;
	private Vector3 cameraDefaultPosition;
	private Vector3 currentVelocity;

	private Camera cam;
	private TheSphere player;

	private bool camZoom = true;
	private bool camFOV = true;

	public Transform ps_friction;

	void Start()
	{
		PrevMp = Input.mousePosition.y;
		cam = GetComponent<Camera>();
		player = GetComponentInParent<TheSphere>();
		cameraDefaultPosition = transform.localPosition;
	}

	// Update is called once per frame
	void Update()
	{
		if(Target != null)
		{
		   

			Vector3 TargetPosition = Target.position + Offset;
			cameraOriginalPosition = transform.parent.position;
			cameraTargetMinPosition = transform.parent.position + (transform.parent.forward * cameraFrontPull);
			cameraTargetMaxPosition = transform.parent.position + (transform.parent.forward * -1 * cameraBackPull);



			if (Input.GetKey(KeyCode.D))
			{
				this.transform.parent.RotateAround(Target.position, Target.transform.up, RotateSpeed * Time.deltaTime);
				this.transform.parent.parent.GetChild(0).RotateAround(Target.position, Target.transform.up, RotateSpeed * Time.deltaTime);
				Vector3 targetVisuelRot = new Vector3(0, this.transform.parent.eulerAngles.y + VisualRotation.y, 0);
				this.transform.parent.parent.GetChild(0).eulerAngles = targetVisuelRot;

			}
			else if (Input.GetKey(KeyCode.A))
			{
				this.transform.parent.RotateAround(Target.position, Target.transform.up, -RotateSpeed * Time.deltaTime);
				this.transform.parent.parent.GetChild(0).RotateAround(Target.position, Target.transform.up, -RotateSpeed * Time.deltaTime );
				Vector3 targetVisuelRot = new Vector3(0, this.transform.parent.eulerAngles.y - VisualRotation.y, 0);
				this.transform.parent.parent.GetChild(0).eulerAngles = targetVisuelRot;

			}else
			{
				transform.parent.parent.GetChild(0).eulerAngles = new Vector3(0f, transform.parent.eulerAngles.y, transform.parent.eulerAngles.z);
			}


			if(Input.GetMouseButton(1))
			{
				float Mp = Input.mousePosition.y;
				if(Mp>PrevMp)
				{
					this.transform.RotateAround(Target.position, Target.transform.right, -RotateSpeed * Time.deltaTime);
				}else if(Mp<PrevMp)
				{
					this.transform.RotateAround(Target.position, Target.transform.right, RotateSpeed * Time.deltaTime);
				}
				PrevMp = Mp;
			}

			this.transform.LookAt(Target.position);

			// Changement du fov en fonction de la vitesse
			if (camFOV)
				cam.fieldOfView = ((player.CurrentSpeed / player.MaxSpeed) * (maxFov - minFov)) + minFov;
			else
				cam.fieldOfView = minFov;

			// Debug
			if (Input.GetKeyDown(KeyCode.J))
			{
				transform.position = cameraTargetMinPosition;
			}
			if (Input.GetKeyDown(KeyCode.K))
			{
				transform.position = cameraOriginalPosition;
			}
			if (Input.GetKeyDown(KeyCode.L))
			{
				transform.position = cameraTargetMaxPosition;
			}

			if (camZoom)
			{
				if (player.currentAcceleration > 0)
					transform.position = Vector3.SmoothDamp(transform.position, cameraTargetMaxPosition, ref currentVelocity, TimeSmooth);
				else if (player.currentAcceleration < 0)
					transform.position = Vector3.SmoothDamp(transform.position, cameraTargetMinPosition, ref currentVelocity, TimeSmooth);
				else
					transform.position = Vector3.SmoothDamp(transform.position, cameraOriginalPosition, ref currentVelocity, TimeSmooth);
			}
			else
				transform.localPosition = cameraDefaultPosition;
		}
	
	}

	public bool ToggleZoom()
	{
		camZoom = !camZoom;
		return camZoom;
	}

	public bool ToggleFOV()
	{
		camFOV = !camFOV;
		return camFOV;
	}

	public void SetZoom(bool t)
	{
		camZoom = t;
	}

	public void SetFOV(bool t)
	{
		camFOV = t;
	}
}
