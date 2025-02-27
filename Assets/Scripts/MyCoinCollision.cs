using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCoinCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject != null)
        {
            Debug.Log("Collision " + collision.gameObject.name);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != null) {
            Debug.Log("Triggered : " + collision.gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
