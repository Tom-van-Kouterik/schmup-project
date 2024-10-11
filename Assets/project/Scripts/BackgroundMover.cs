using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    private float movementSpeed = -1f;
    private Vector3 endPosition = new(0, -12, 0);
    private Vector3 startPosition = new(0, 12, 0);
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y <= endPosition.y)
        {
            this.transform.position = startPosition;
            Debug.Log("teleport complete");
        }
    }


    void FixedUpdate()
    {
        this.transform.position += new Vector3(0, movementSpeed * Time.deltaTime, 0);
    }
}
