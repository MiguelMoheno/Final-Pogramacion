using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConseguirLlaves : MonoBehaviour
{
    public bool detect;
    public float radius;
    public LayerMask player;
    
    private GameObject manager;
    private GameManager gameManager;

    public bool check;

    private void Start()
    {
        
            manager = GameObject.FindGameObjectWithTag("GameManager");
            gameManager = manager.GetComponent<GameManager>();
        
    }

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

        if (check && Input.GetKeyDown(KeyCode.E) && detect)
        {
            
            

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
