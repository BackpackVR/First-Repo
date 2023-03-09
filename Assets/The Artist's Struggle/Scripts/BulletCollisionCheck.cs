using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionCheck : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fractured"))
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}
