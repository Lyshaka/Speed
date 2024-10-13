using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    TextMeshProUGUI t;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<TextMeshProUGUI>();
        StartCoroutine(UpdateCounter());
    }

    IEnumerator UpdateCounter()
    {
        yield return new WaitForSeconds(0.1f);
        t.text = "FPS : " + (1f/Time.unscaledDeltaTime);
        StartCoroutine(UpdateCounter());
    }
}
