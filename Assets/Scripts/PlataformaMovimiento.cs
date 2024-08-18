using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovimiento : MonoBehaviour
{
    public Transform inicio;
    public Transform final;
    public Transform plataforma;
    public float speed;
    private Vector3 target;

    void Start()
    {
        
        target = final.position;
    }

    void Update()
    {

        plataforma.transform.position = Vector3.MoveTowards(plataforma.transform.position, target, speed * Time.deltaTime);


        if (Vector3.Distance(plataforma.transform.position, target) < 0.1f)
        {
            target = target == inicio.position ? final.position : inicio.position;
        }
    }
}
