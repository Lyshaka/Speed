using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossingSoundManagerEnd : MonoBehaviour
{
    public float fadeOutTime = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3)
        {
            Debug.Log("end");
            StartCoroutine(DeactivateSound());
        }
    }

    IEnumerator DeactivateSound()
    {
        AudioSource audioSource = GetComponentInParent<AudioSource>();
        float elapsedTime = 0.0f;

        audioSource.volume = 0.0f;
        while (elapsedTime < fadeOutTime)
        {
            audioSource.volume = 1.0f - (elapsedTime / fadeOutTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        audioSource.volume = 0.0f;
        audioSource.Stop();
    }
}
