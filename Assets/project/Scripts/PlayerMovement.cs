using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    void Start()
    {
        
    }


    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        transform.Translate(direction * Time.deltaTime * movementSpeed, 0, 0);

        if (Input.inputString != "") Debug.Log(Input.inputString);
    }
}
