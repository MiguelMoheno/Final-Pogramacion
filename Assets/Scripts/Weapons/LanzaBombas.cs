using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LanzaBombas : MonoBehaviour
{
    public GameObject bombas;
    public float force;


    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            for(int i = 0; 1 <transform.childCount; i++)
            {
                GameObject clon = Instantiate(bombas, transform.GetChild(i).position,transform.GetChild(i).rotation);
                clon.GetComponent<Rigidbody>().AddForce(transform.GetChild(i).forward * force);
                Destroy(clon, 5);

            }
           
        }
    }
}
