using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public int[] monedas;
    public TextMeshProUGUI llaveText;
    public int llave = 0;
    public GameObject enemyPrefab;
    public Transform[] spawns;
    public float spawnDelay;

    public string nivel;

    public float posx;
    public float posy;
    public float posz;
    

    public string saveName = "/eljuguito.unity";

    private void Start()
    {
        SpawnEnemies();
    }
    void SpawnEnemies()
    {
        foreach(Transform spawn in spawns)
        {
            SpawnEnemy(spawn.position);
        }

    }
    
    public void SpawnEnemy(Vector3 position)
    {
        Instantiate(enemyPrefab, position, Quaternion.identity);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);

        }

    }


    public void AddLlave(int amount)
    {
        llave += amount;
        UpdateLlaveText();
    }

    private void UpdateLlaveText()
    {
        llaveText.text = "Llaves x" + llave.ToString();
        Debug.Log("Ganaste");
    }
   
}
