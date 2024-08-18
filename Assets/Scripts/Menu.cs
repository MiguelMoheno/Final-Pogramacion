using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

   
    public void GameStart()
    {

        SceneManager.LoadScene("GameHorror");
        Debug.Log("Pasa escena");


    }

    public void ExitGame()
    {

        Application.Quit();
        Debug.Log("Sales del juego");
    }

}
