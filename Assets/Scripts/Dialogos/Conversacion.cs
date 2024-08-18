using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Conversacion : MonoBehaviour
{
    public Dialogos[] dialogue;

    public GameObject interfaz;
    public GameObject battery;

    public TextMeshProUGUI names;
    public TextMeshProUGUI text;

    public Image character1;
    public Image character2;
    public Image box;
    

    private int line = 0;

    public bool inside;
    public float radius;
    public LayerMask player;

    
    private void Update()
    {
        inside = Physics.CheckSphere(transform.position, radius, player);
        if (inside && Input.GetKeyDown(KeyCode.E) && line >= dialogue.Length)
        {
            interfaz.SetActive(false);
            battery.SetActive(true);

            names.text = null;
            text.text = null;

            character1.sprite = null;
            character2.sprite = null;
            
            box.sprite = null;
            AudioManager.instance.Stop("Npc");
            line = 0;
        }


        else if (inside && Input.GetKeyDown(KeyCode.E))
        {
            AudioManager.instance.Play("Npc");
            interfaz.SetActive(true);
            battery.SetActive(false);
            names.text = dialogue[line].name;
            text.text = dialogue[line].words;

            character1.sprite = dialogue[line].face1;
            character2.sprite = dialogue[line].face2;
            
            box.sprite = dialogue[line].box;
            line++;
        }
        
       
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}
