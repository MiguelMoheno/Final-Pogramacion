using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirPuerta : MonoBehaviour
{
    public Item itemNecesario;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Abrir(Inventario inventario)
    {
        if(inventario.ItemColect(itemNecesario))
        {

            Abierto();
        }
        else
        {
            Debug.Log("No puedes abrir la peurta, objeto faltante");
        }
    }

     void Abierto()
    {
        Destroy(this.gameObject);
    }
}
