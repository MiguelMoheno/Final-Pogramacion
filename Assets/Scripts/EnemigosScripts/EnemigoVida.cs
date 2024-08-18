using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoVida : MonoBehaviour, IDamage
{
    public float vida;
    
    public void Danio(float cantidad)
    {
        vida -= cantidad;
        
        if(vida <= 0 )
        {
            Destroy(this.gameObject);
        }

    }
}
