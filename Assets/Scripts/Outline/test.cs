using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private Material outlineMaterial;
    [SerializeField] private float outlineWidth;
    [SerializeField] private Color outlineColor;
    private Renderer outlineRenderer;

    void Start()
    {
        outlineRenderer = CreateOutline(outlineMaterial, outlineWidth, outlineColor);
        outlineRenderer.enabled = false;
    }

    Renderer CreateOutline(Material outlineMat, float width, Color color)
    {
        GameObject outlineObject = new GameObject("Outline");
        outlineObject.transform.parent = transform;
        outlineObject.transform.localPosition = Vector3.zero;
        outlineObject.transform.localRotation = Quaternion.identity;
        outlineObject.transform.localScale = Vector3.one;

        Renderer rend = outlineObject.AddComponent<MeshRenderer>();
        MeshFilter filter = outlineObject.AddComponent<MeshFilter>();

        filter.mesh = GetComponent<MeshFilter>().mesh;

        Material mat = new Material(outlineMat);
        mat.SetColor("_Color", color);
        mat.SetFloat("_Width", width);

        rend.material = mat;
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;

        return rend;
    }

    void OnMouseEnter()
    {
        outlineRenderer.enabled = true;
    }

    void OnMouseExit()
    {
        outlineRenderer.enabled = false;
    }
}