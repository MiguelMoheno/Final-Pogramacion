using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyRutine : MonoBehaviour
{
    public int routine;
    public float chronometer;
    public Quaternion angle;
    public float grade;

    private void Start()
    {
            
    }

    public void EnemyRoutine()
    {
        chronometer += 1 * Time.deltaTime;

        if (chronometer >=4)
        {
            routine = Random.Range(0, 2);
            chronometer = 0;
        }
        switch (routine) 
        {
                case 0:

                break;

                case 1: 

                grade = Random.Range(0, 360);
                angle = Quaternion.Euler(0, grade, 0);
                routine++;
                break;


                case 2:

                transform.rotation = Quaternion.RotateTowards(transform.rotation, angle, 0.5f);
                transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                break;
        


        }
        

    }

    private void Update()
    {
        EnemyRoutine(); 
    }
}
