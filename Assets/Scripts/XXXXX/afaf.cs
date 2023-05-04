/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afaf : MonoBehaviour
{
    [SerializeField] public Material outlineMaterial;
    [SerializeField] public float outlineWidth = 0.1f;
    [SerializeField] public Color outlineColor = Color.white;

    public Renderer objectRenderer;
    public Material outlineInstance;

    public void Awake()
    {
        objectRenderer = GetComponent<Renderer>();
        outlineInstance = new Material(outlineMaterial);
        outlineInstance.SetFloat("_OutlineWidth", outlineWidth);
        outlineInstance.SetColor("_OutlineColor", outlineColor);
    }

    public void OnMouseOver()
    {
        objectRenderer.material = outlineInstance;
    }

    public void OnMouseExit()
    {
        objectRenderer.material = outlineMaterial;
    }
}
*/