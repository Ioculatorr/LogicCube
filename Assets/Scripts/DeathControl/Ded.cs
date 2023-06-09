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
            // Powrót na pozycjê pocz¹tkow¹
            transform.position = initialPosition;

            // Resetowanie prêdkoœci
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("umieranko"))
        {
            // Powrót na pozycjê pocz¹tkow¹
            transform.position = initialPosition;

            // Resetowanie prêdkoœci
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
/*public class ded : MonoBehaviour
{
    public Transform checkpoint; // referencja do checkpointa
    public LayerMask dedLayer; // warstwa obiektu, który teleportuje gracza

    private void OnTriggerEnter(Collider other)
    {
        // Sprawdzamy, czy gracz dotkn¹³ obiektu z w³aœciw¹ warstw¹
        if (other.gameObject.tag == "umieranko")
        {
            // Jeœli tak, teleportujemy gracza do checkpointa
            other.transform.position = checkpoint.position;
        }
    }
}
*/