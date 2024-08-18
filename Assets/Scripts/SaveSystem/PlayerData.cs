using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData 
{
    public int llaves;

    public string nivel;




    public float posx;
    public float posy;
    public float posz;

    public PlayerData()
    {
        llaves = GameManager.Instance.llave;

        nivel = GameManager.Instance.nivel;

        posx = GameManager.Instance.posx;
        posy = GameManager.Instance.posy;
        posz = GameManager.Instance.posz;
    }
}
