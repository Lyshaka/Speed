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
	public Image riverSR;
	public Image cascadeSR;
	public Image fairyWheelSR;
	public Image crowdStandsSR;
	public Image tunnelsSR;
	public Image streetLightsSR;
	public Image treesSR;
	public Image archesSR;
	public Image adSpotSR;
	public Image trailRendererSR;
	public Image speedParticleSR;
	public Image trainTrackSR;
	public Image musicSR;

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
	public GameObject riverObject;
	public GameObject cascadeObject;
	public GameObject fairyWheelObject;
	public GameObject crowdStandsObject;
	public GameObject tunnelsObject;
	public GameObject streetLightsObject;
	public GameObject treesObject;
	public GameObject archesObject;
	public GameObject adSpotObject;
	public GameObject trailRendererObject;
	public GameObject speedParticleObject;
	public GameObject trainTrackObject;
	public GameObject musicObject;

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
		riverObject.SetActive(true);
		cascadeObject.SetActive(true);
		fairyWheelObject.SetActive(true);
		crowdStandsObject.SetActive(true);
		tunnelsObject.SetActive(true);
		streetLightsObject.SetActive(true);
		treesObject.SetActive(true);
		archesObject.SetActive(true);
		adSpotObject.SetActive(true);
		trailRendererObject.SetActive(true);
		speedParticleObject.SetActive(true);
		trainTrackObject.SetActive(true);
		musicObject.SetActive(true);

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
		riverSR.sprite = activatedSprite;
		cascadeSR.sprite = activatedSprite;
		fairyWheelSR.sprite = activatedSprite;
		crowdStandsSR.sprite = activatedSprite;
		tunnelsSR.sprite = activatedSprite;
		streetLightsSR.sprite = activatedSprite;
		treesSR.sprite = activatedSprite;
		archesSR.sprite = activatedSprite;
		adSpotSR.sprite = activatedSprite;
		trailRendererSR.sprite = activatedSprite;
		speedParticleSR.sprite = activatedSprite;
		trainTrackSR.sprite = activatedSprite;
		musicSR.sprite = activatedSprite;
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
		riverObject.SetActive(false);
		cascadeObject.SetActive(false);
		fairyWheelObject.SetActive(false);
		crowdStandsObject.SetActive(false);
		tunnelsObject.SetActive(false);
		streetLightsObject.SetActive(false);
		treesObject.SetActive(false);
		archesObject.SetActive(false);
		adSpotObject.SetActive(false);
		trailRendererObject.SetActive(false);
		speedParticleObject.SetActive(false);
		trainTrackObject.SetActive(false);
		musicObject.SetActive(false);

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
		riverSR.sprite = deactivatedSprite;
		cascadeSR.sprite = deactivatedSprite;
		fairyWheelSR.sprite = deactivatedSprite;
		crowdStandsSR.sprite = deactivatedSprite;
		tunnelsSR.sprite = deactivatedSprite;
		streetLightsSR.sprite = deactivatedSprite;
		treesSR.sprite = deactivatedSprite;
		archesSR.sprite = deactivatedSprite;
		adSpotSR.sprite = deactivatedSprite;
		trailRendererSR.sprite = deactivatedSprite;
		speedParticleSR.sprite = deactivatedSprite;
		trainTrackSR.sprite = deactivatedSprite;
		musicSR.sprite = deactivatedSprite;
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

	public void ToggleRiver()
	{
		riverObject.SetActive(!riverObject.activeSelf);
		riverSR.sprite = riverObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleCascade()
	{
		cascadeObject.SetActive(!cascadeObject.activeSelf);
		cascadeSR.sprite = cascadeObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleFairyWheel()
	{
		fairyWheelObject.SetActive(!fairyWheelObject.activeSelf);
		fairyWheelSR.sprite = fairyWheelObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleCrowdStands()
	{
		crowdStandsObject.SetActive(!crowdStandsObject.activeSelf);
		crowdStandsSR.sprite = crowdStandsObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleTunnels()
	{
		tunnelsObject.SetActive(!tunnelsObject.activeSelf);
		tunnelsSR.sprite = tunnelsObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleStreetLights()
	{
		streetLightsObject.SetActive(!streetLightsObject.activeSelf);
		streetLightsSR.sprite = streetLightsObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleTrees()
	{
		treesObject.SetActive(!treesObject.activeSelf);
		treesSR.sprite = treesObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleArches()
	{
		archesObject.SetActive(!archesObject.activeSelf);
		archesSR.sprite = archesObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleAdSpot()
	{
		adSpotObject.SetActive(!adSpotObject.activeSelf);
		adSpotSR.sprite = adSpotObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleTrailRenderer()
	{
		trailRendererObject.SetActive(!trailRendererObject.activeSelf);
		trailRendererSR.sprite = trailRendererObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleSpeedParticle()
	{
		speedParticleObject.SetActive(!speedParticleObject.activeSelf);
		speedParticleSR.sprite = speedParticleObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleTrainTrack()
	{
		trainTrackObject.SetActive(!trainTrackObject.activeSelf);
		trainTrackSR.sprite = trainTrackObject.activeSelf ? activatedSprite : deactivatedSprite;
	}

	public void ToggleMusic()
	{
		musicObject.SetActive(!musicObject.activeSelf);
		musicSR.sprite = musicObject.activeSelf ? activatedSprite : deactivatedSprite;
	}
}
