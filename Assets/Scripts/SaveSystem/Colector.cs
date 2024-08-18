using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colector : MonoBehaviour
{
    public Item item;

    public void Collection(Inventario inventario)
    {
        inventario.AddItem(item);
        Destroy(gameObject);
    }
}
