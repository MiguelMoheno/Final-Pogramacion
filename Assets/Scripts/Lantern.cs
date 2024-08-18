using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lantern : MonoBehaviour
{
    public Light lanternCheck;
    [Header("Energia")]
    public float actualEnergy = 100f;
    public float maxEnergy = 100f;
    public float energyVelocity = 0.2f;
    public float velocityRecharge;

    [Header("Interfaz")]
    public Image bateryBox;


    private void Start()
    {
        
    }
    
    private void Update()
    {
        if(Input.GetButtonDown("Linterna"))
        {
            if(lanternCheck.enabled == true)
            {
                lanternCheck.enabled = false;
            }
            else if(lanternCheck.enabled == false && actualEnergy > 10)
            {
                lanternCheck.enabled = true;
            }

        }
        if (lanternCheck.enabled == true)
        {
            actualEnergy -= Time.deltaTime * energyVelocity;

            if(actualEnergy <= 0 )
            {
                actualEnergy = 0;
                lanternCheck.enabled = false;
            }
        }
        else if (lanternCheck.enabled == false)
        {
            actualEnergy += Time.deltaTime * velocityRecharge;
            if(actualEnergy > maxEnergy )
            {
                actualEnergy = maxEnergy;
            }
        }

        bateryBox.fillAmount = actualEnergy / maxEnergy;
    }

}
