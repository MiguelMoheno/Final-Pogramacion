using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{

    private CharacterController ctrl;
    private float movX;
    private float movZ;
    private Vector3 movi;
   

    public float vel;
    public Vector3 velY;
    public float speedJump;
    public float sprintSpeed;
    public float walkSpeed;
    public float gravedad = -9.8f;
    
    private float alturaOriginal;
    private bool isGrounded;
    public Transform groundCheck;
    public float radius;
    public LayerMask groundMask;
    public float crouchHeight = 0.25f;  
    public float transitionSpeed = 5f; 
    private Vector3 alturaPrincipal;
    private Vector3 crouchScale;
    



    void Start()
    {
        transform.position = new Vector3(GameManager.Instance.posx, GameManager.Instance.posy, GameManager.Instance.posz);
       ctrl = GetComponent<CharacterController>();
        alturaPrincipal = transform.localScale;
        
        
        crouchScale = new Vector3(alturaPrincipal.x, crouchHeight, alturaPrincipal.z);
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, radius, groundMask);

        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
         

        
        movi = transform.right * movX + transform.forward * movZ;
        ctrl.Move(movi * vel * Time.deltaTime);

        if(isGrounded && velY.y < 0 )
        {
            velY.y = 0;

        }
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            vel = sprintSpeed;
        }
        else
        {
            vel = walkSpeed;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {

            velY.y = Mathf.Sqrt(speedJump * -2 * gravedad);
        }
        if (Input.GetKey(KeyCode.LeftControl)) 
        {
            
            transform.localScale = Vector3.Lerp(transform.localScale, crouchScale, Time.deltaTime * transitionSpeed);
        }
        else
        {
            
            transform.localScale = Vector3.Lerp(transform.localScale, alturaPrincipal, Time.deltaTime * transitionSpeed);
        }
       





        velY.y += gravedad * Time.deltaTime;
        ctrl.Move(velY * Time.deltaTime);
          
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
    }


}
