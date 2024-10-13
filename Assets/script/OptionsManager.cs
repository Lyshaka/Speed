using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
	[Header("General")]
	public GameObject optionsObject;
	public Sprite activatedSprite;
	public Sprite deactivatedSprite;
	public Camfollow camfollowScript;
	public Material roadOn;
	public Material roadOff;

	[Header("Image Renderers")]
	public Image rainSR;
	public Image snowSR;
	public Image cameraZoomSR;
	public Image cameraFOVSR;
	public Image smokeSR;
	public Image cylindersSR;
	public Image mountainsSR;
	public Image trainSR;
	public Image railCrossingSR;
	public Image roadStripsSR;
	public Image frictionSR;
	public Image lightHouseSR;

	[Header("Game Objects")]
	public GameObject rainObject;
	public GameObject snowObject;
	public GameObject smokeObject;
	public GameObject cylindersObject;
	public GameObject mountainsObject;
	public GameObject trainObject;
	public GameObject railCrossingObject;
	public GameObject roadStripsObject;
	public GameObject frictionObject;
	public GameObject lightHouseObject;

	public void ToggleOptions()
	{
		optionsObject.SetActive(!optionsObject.activeSelf);
	}

	public void ActivateAll()
	{
		rainObject.SetActive(true);
		snowObject.SetActive(true);
		camfollowScript.SetZoom(true);
		camfollowScript.SetFOV(true);
		smokeObject.SetActive(true);
		cylindersObject.SetActive(true);
		mountainsObject.SetActive(true);
		trainObject.SetActive(true);
		railCrossingObject.SetActive(true);
		roadStripsObject.GetComponent<MeshRenderer>().sharedMaterial = roadOn;
		frictionObject.SetActive(true);
		lightHouseObject.SetActive(true);

	rainSR.sprite = activatedSprite;
		snowSR.sprite = activatedSprite;
		cameraZoomSR.sprite = activatedSprite;
		cameraFOVSR.sprite = activatedSprite;
		smokeSR.sprite = activatedSprite;
		cylindersSR.sprite = activatedSprite;
		mountainsSR.sprite = activatedSprite;
		trainSR.sprite = activatedSprite;
		railCrossingSR.sprite = activatedSprite;
		roadStripsSR.sprite = activatedSprite;
		frictionSR.sprite = activatedSprite;
		lightHouseSR.sprite = activatedSprite;
	}

	public void DeactivateAll()
	{
		rainObject.SetActive(false);
		snowObject.SetActive(false);
		camfollowScript.SetZoom(false);
		camfollowScript.SetFOV(false);
		smokeObject.SetActive(false);
		cylindersObject.SetActive(false);
		mountainsObject.SetActive(false);
		trainObject.SetActive(false);
		railCrossingObject.SetActive(false);
		roadStripsObject.GetComponent<MeshRenderer>().sharedMaterial = roadOff;
		frictionObject.SetActive(false);
		lightHouseObject.SetActive(false);

		rainSR.sprite = deactivatedSprite;
		snowSR.sprite = deactivatedSprite;
		cameraZoomSR.sprite = deactivatedSprite;
		cameraFOVSR.sprite = deactivatedSprite;
		smokeSR.sprite = deactivatedSprite;
		cylindersSR.sprite = deactivatedSprite;
		mountainsSR.sprite = deactivatedSprite;
		trainSR.sprite = deactivatedSprite;
		railCrossingSR.sprite = deactivatedSprite;
		roadStripsSR.sprite = deactivatedSprite;
		frictionSR.sprite = deactivatedSprite;
		lightHouseSR.sprite = deactivatedSprite;
	}

	public void ToggleRain()
	{
		rainObject.SetActive(!rainObject.activeSelf);
		rainSR.sprite = rainObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleSnow()
	{
		snowObject.SetActive(!snowObject.activeSelf);
		snowSR.sprite = snowObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleCamZoom()
	{
		bool t = camfollowScript.ToggleZoom();
		cameraZoomSR.sprite = t ? activatedSprite : deactivatedSprite;
	}

	public void ToggleCamFov()
	{
		bool t = camfollowScript.ToggleFOV();
		cameraFOVSR.sprite = t ? activatedSprite : deactivatedSprite;
	}

	public void ToggleSmoke()
	{
		smokeObject.SetActive(!smokeObject.activeSelf);
		smokeSR.sprite = smokeObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleCylinders()
	{
		cylindersObject.SetActive(!cylindersObject.activeSelf);
		cylindersSR.sprite = cylindersObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleMountains()
	{
		mountainsObject.SetActive(!mountainsObject.activeSelf);
		mountainsSR.sprite = mountainsObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleTrain()
	{
		trainObject.SetActive(!trainObject.activeSelf);
		trainSR.sprite = trainObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleRailCrossing()
	{
		railCrossingObject.SetActive(!railCrossingObject.activeSelf);
		railCrossingSR.sprite = railCrossingObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleRoadStrips()
	{
		MeshRenderer mr = roadStripsObject.GetComponent<MeshRenderer>();
		if (mr.sharedMaterial.name == roadOn.name)
		{
			mr.sharedMaterial = roadOff;
			roadStripsSR.sprite = deactivatedSprite;
		}
		else
		{
			mr.sharedMaterial = roadOn;
			roadStripsSR.sprite = activatedSprite;
		}
	}

	public void ToggleFriction()
	{
		frictionObject.SetActive(!frictionObject.activeSelf);
		frictionSR.sprite = frictionObject.activeSelf ? activatedSprite : deactivatedSprite;
	}
	public void ToggleLightHouse()
	{
		lightHouseObject.SetActive(!lightHouseObject.activeSelf);
		lightHouseSR.sprite = lightHouseObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

}
