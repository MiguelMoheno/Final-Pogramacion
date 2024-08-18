using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovimiento : MonoBehaviour
{
    private float musX;
    private float musY;

    public float musSenseX;
    public float musSenseY;

    private Transform pers;

    private float camRot = 0;
    private void Start()
    {
        pers = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        musX = Input.GetAxis("Mouse X") * musSenseX * Time.deltaTime;

        musY = Input.GetAxis("Mouse Y") * musSenseY * Time.deltaTime;

        camRot -= musY;

        camRot = Mathf.Clamp(camRot, -90, 90);

        transform.localRotation = Quaternion.Euler(camRot, 0, 0);
       
        pers.Rotate(Vector3.up * musX);
    }
}
