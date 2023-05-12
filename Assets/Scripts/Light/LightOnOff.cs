
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light myLight;

    private void Start()
    {
        myLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myLight.enabled = true;
        }
    }
}
