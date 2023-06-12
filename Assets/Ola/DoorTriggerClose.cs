using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerClose : MonoBehaviour
{
    [SerializeField] private GameObject door;

    bool isOpened = false;
    public float doorCoolDown = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpened)
        {
            isOpened = true;
            door.transform.position += new Vector3(0, 4, 0);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (isOpened)
        {
            isOpened = false;
            door.transform.position -= new Vector3(0, 4, 0);
        }
    }
}
