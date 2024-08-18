using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConseguirMoneda : MonoBehaviour
{
    public bool detect;
    public float radius;
    public LayerMask player;
   

    public bool check;
    public int tipo;


    private void OnMouseOver()
    {
        check = true;
    }

    private void OnMouseExit()
    {
        check = false;

    }
    private void Update()
    {
        detect = Physics.CheckSphere(transform.position, radius, player);

        if(check && Input.GetKeyDown(KeyCode.E) && detect) 
        { 
            Destroy(this.gameObject);
            GameManager.Instance.monedas[tipo]++;

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta; 
        Gizmos.DrawWireSphere(transform.position, radius); 
    }
}
