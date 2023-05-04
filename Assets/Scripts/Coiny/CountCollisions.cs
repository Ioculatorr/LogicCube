using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollisions : MonoBehaviour
{
    public int scoreValue = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            scoreValue++;
            Debug.Log("Score: " + scoreValue);
        }
    }
}
