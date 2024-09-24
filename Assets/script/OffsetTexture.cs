using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetTexture : MonoBehaviour
{
    public Material mat;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset = new Vector2(mat.mainTextureOffset.x + speed * Time.deltaTime, 0.0f);
    }
}
