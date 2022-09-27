using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float movementSpeed;
    public CharacterController characterController;

    private Vector3 movementVector;
   
    void Start()
    {
        characterController = GetComponent <CharacterController>();
    }


    void Update()
    {
        movementVector.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        movementVector.z = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        characterController.Move(movementVector); 
    }

     

}
