using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Arma : MonoBehaviour
{
    private RaycastHit hit;
    public float distancia;
    private Transform cam;
    private ParticleSystem parti;
    public float empuje;
    public int danio;
    public Inventario inventario;
    private GameObject colect;

    public Transform partS;

    private void Start()
    {
        cam = transform.parent;
        parti = transform.GetChild(0).GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            parti.Play();
            if (Physics.Raycast(cam.position, cam.forward, out hit, distancia))
            {
                Debug.Log(hit.transform.name);

                Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
                if (rb != null)
                {

                    Vector3 forceDirection = hit.point - transform.position;
                    forceDirection.Normalize();


                    rb.AddForce(forceDirection * empuje, ForceMode.Impulse);
                }
            }
            if (hit.transform.tag == "Enemigo")
            {

                Instantiate(partS, hit.point, partS.rotation);

            }
            if (hit.transform.tag == "Caja")
            {
                colect = hit.transform.gameObject;
                hit.transform.parent = transform.parent;
                hit.transform.GetComponent<Rigidbody>().isKinematic = true;

            }

        }


        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, distancia))
        {

            Colector coleccionable = hit.transform.GetComponent<Colector>();
            AbrirPuerta door = hit.transform.GetComponent<AbrirPuerta>();

            if (Input.GetKeyDown(KeyCode.F))
            {

                if (coleccionable != null)
                {
                    coleccionable.Collection(inventario);
                }

                if (door != null)
                {
                    door.Abrir(inventario);
                }

                if (Input.GetMouseButtonDown(1))
                {
                    colect.GetComponent<Rigidbody>().isKinematic = false;
                    colect.transform.parent = null;
                    colect = null;

                }

            }
        }
    }
}
