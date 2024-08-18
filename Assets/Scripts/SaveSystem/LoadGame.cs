using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadGame();

        if(data != null )
        {
            GameManager.Instance.llave = data.llaves;

            GameManager.Instance.nivel = data.nivel;

            GameManager.Instance.posx = data.posx;
            GameManager.Instance.posy = data.posy;
            GameManager.Instance.posz = data.posz;
            SceneManager.LoadScene(GameManager.Instance.nivel);
        }
        else
        {

            SceneManager.LoadScene("NewGame");
        }
        
        
    }
}
