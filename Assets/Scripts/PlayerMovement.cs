using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardSpeed = 15f;
    public float movementSpeed = 15f;

    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        rb.AddForce((1f + verticalMovement) * forwardSpeed * Time.deltaTime, 0, -movementSpeed * horizontalMovement * Time.deltaTime, ForceMode.VelocityChange);
    }
}
