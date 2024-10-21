using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetTexture : MonoBehaviour
{
	Renderer mat;
	public float speed;

	// Start is called before the first frame update
	void Start()
	{
		mat = GetComponentInChildren<Renderer>();
	}

	// Update is called once per frame
	void Update()
	{
		mat.material.mainTextureOffset = new Vector2(mat.material.mainTextureOffset.x + speed * Time.deltaTime, 0.0f);
	}
}
