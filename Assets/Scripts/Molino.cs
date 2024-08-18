using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molino : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 0, 0); 

    void Update()
    {
        
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
