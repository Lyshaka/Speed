using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossingSoundManagerStart : MonoBehaviour
{
    public float fadeInTime = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            Debug.Log("start");
            StartCoroutine(ActivateSound());
        }
    }

    IEnumerator ActivateSound()
    {
        AudioSource audioSource = GetComponentInParent<AudioSource>();
        float elapsedTime = 0.0f;

        audioSource.volume = 0.0f;
        audioSource.Play();
        while (elapsedTime < fadeInTime)
        {
            audioSource.volume = elapsedTime / fadeInTime;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        audioSource.volume = 1.0f;
    }
}
