using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ded : MonoBehaviour
{
    public KeyCode respawnKey = KeyCode.P;
    public Transform spawnPoint;

    private Rigidbody rb;
    private Vector3 initialPosition; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(respawnKey))
        {
            // Powr�t na pozycj� pocz�tkow�
            transform.position = initialPosition;

            // Resetowanie pr�dko�ci
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("umieranko"))
        {
            // Powr�t na pozycj� pocz�tkow�
            transform.position = initialPosition;

            // Resetowanie pr�dko�ci
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
/*public class ded : MonoBehaviour
{
    public Transform checkpoint; // referencja do checkpointa
    public LayerMask dedLayer; // warstwa obiektu, kt�ry teleportuje gracza

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdzamy, czy gracz dotkn�� obiektu z w�a�ciw� warstw�
        if (other.gameObject.tag == "umieranko")
        {
            // Je�li tak, teleportujemy gracza do checkpointa
            other.transform.position = checkpoint.position;
        }
    }
}
*/