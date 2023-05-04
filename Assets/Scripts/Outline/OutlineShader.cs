using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineShader : MonoBehaviour
{
    [SerializeField] private float outlineWidth;
    [SerializeField] private Color outlineColor;

    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material = new Material(Shader.Find("Outlined/Silhouetted Diffuse"));
        rend.material.SetColor("_OutlineColor", outlineColor);
        rend.material.SetFloat("_Outline", outlineWidth);
    }
}