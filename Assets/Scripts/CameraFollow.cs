using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Assign the Player object to this field in the Inspector
    public float height = 10.0f; // Adjust the height of the bird's eye view
    public float distance = 5.0f; // Adjust the distance from the player


    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target not assigned for the camera.");
            return;

        }
        // Calculate the rotated offset to match the player's rotation
        Vector3 rotatedOffset = Quaternion.AngleAxis(target.eulerAngles.y, Vector3.up) * new Vector3(0, height, -distance);

        // Set the camera's position based on the player's position and the rotated offset
        transform.position = target.position + rotatedOffset;

        // Make the camera always look at the player's position
        transform.LookAt(target.position);

    }
}
