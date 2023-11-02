using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust the movement speed as needed
    public float rotationSpeed = 100.0f; // Adjust rotation speed as needed

    void Update()
    {
        // Player Rotation with Q and E keys
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // Player Movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply movement to the player object
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
