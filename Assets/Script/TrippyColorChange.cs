using UnityEngine;

public class TrippyColorChange : MonoBehaviour
{
	Renderer objectRenderer;  // Assign this in the inspector or via script
	public float frequency = 1.0f;   // How fast the colors change
	public float amplitude = 0.5f;   // Range of the color fluctuation

	private Material material;

	void Start()
	{
		if (objectRenderer == null)
		{
			objectRenderer = GetComponent<Renderer>();
		}

		material = objectRenderer.material;
	}

	void Update()
	{
		// Generate color values based on a sine wave and time
		float r = Mathf.Sin(Time.time * frequency) * amplitude + 0.5f;
		float g = Mathf.Sin((Time.time * frequency) + Mathf.PI / 2) * amplitude + 0.5f;
		float b = Mathf.Sin((Time.time * frequency) + Mathf.PI) * amplitude + 0.5f;

		// Set the material's color to the new value
		material.color = new Color(r, g, b);
	}
}
