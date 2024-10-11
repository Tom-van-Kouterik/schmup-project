using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 4f;
    private void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        transform.Translate(direction * Time.deltaTime * movementSpeed, 0, 0);
    }
}
