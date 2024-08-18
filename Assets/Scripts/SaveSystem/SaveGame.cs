using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
     public GameObject player;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("agarra");
            player = GameObject.FindGameObjectWithTag("Player");

            GameManager.Instance.posx = player.transform.position.x;
            GameManager.Instance.posy = player.transform.position.y;
            GameManager.Instance.posz = player.transform.position.z;

            GameManager.Instance.nivel = SceneManager.GetActiveScene().name;

            SaveSystem.SaveGame();

        }
    }
}
