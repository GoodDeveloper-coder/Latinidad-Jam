using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float friction = 10.0f; 
    private Rigidbody2D rb;

    private Vector2 currentVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 inputVector = new Vector2(horizontalInput, verticalInput).normalized;

        currentVelocity = Vector2.Lerp(currentVelocity, inputVector * moveSpeed, Time.deltaTime * friction);

        rb.velocity = currentVelocity;
    }
}



