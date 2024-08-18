using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rebote : MonoBehaviour
{
    public float empuje;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pelota"))
        {
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direccion = transform.position -rb.transform.position;
                


                rb.AddForce( direccion * empuje, ForceMode.Impulse);
            }

        }
    }

}
