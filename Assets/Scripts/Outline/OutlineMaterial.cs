using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineMaterial : MonoBehaviour
{
    [SerializeField] private Material outlineMaterial;
    [SerializeField] private float outlineWidth;
    [SerializeField] private Color outlineColor;

    void Start()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material = Instantiate(rend.material);
        rend.material.shader = Shader.Find("Outlined/Silhouetted Diffuse");
        rend.material.SetColor("_OutlineColor", outlineColor);
        rend.material.SetFloat("_Outline", outlineWidth);
    }
}