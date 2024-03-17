using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    private Vector3 previousMousePosition; // Stores the mouse xyz position in a Vector3
    private Transform cameraTransform; // Store the transform (position, rotation, scale) in the variable cameraTransform
    public float rotationSpeed = 5.0f;

    // Start is called before the first frame update
    // Start will not run unless that game object it's attached to is in the scene hierarchy and is also active and enabled
    void Start()
    {
        cameraTransform = Camera.main.transform; // Camera.main returns first camera named "Main Camera" in scene
    }

    // Update is called once per frame
    // Time between frames can vary so logic inside of this method should account for that for consistent behavior
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // This will check if the mouse button has been pressed down regardless if it is held down or not
        {
            previousMousePosition = Input.mousePosition; // Get the current pixel coordinates that mouse is at in a Vector3
                                                         // Then set that equal to the Vector3 previousMousePosition variable
        }

        if (Input.GetMouseButton(0)) // Checks if the left mouse button is being held down, not just pressed and then released
        {
            Vector3 mouseDelta = Input.mousePosition - previousMousePosition; /* Use vector subtraction to find the vector going from the
                                                                                 previousMousePosition (tail) to the curent mouse position (head) */
            
            float rotationX = mouseDelta.y * rotationSpeed * Time.deltaTime; // mouseDelta.y is the verical movement of the mouse since the previous frame
                                                                             // Time.deltaTime makes sure that the rotation speed is the same for different devices
                                                                             // it's mouseDelta.y and not x because you're rotating on the x-axis when moving up and down
                                                                                // If there was a line that went though the sphere and it rotated on it, the line would be horizontal
                                                                                // But the movement would be up and down to make that horizontal so it's using the y / verical movement of the mouse
                                                                            // rotationX is a number (float) and the larger the distance from the previous mouse position and
                                                                                // current mouse position, the larger that number is going to be
                                                                                // this means that the amount it rotates by will be more than if the difference was smaller
            
            float rotationY = -mouseDelta.x * rotationSpeed * Time.deltaTime; // mouseDelta.x is negative because mouseDelta.x is relative to the objects local coordinate system
                                                                              // if you were viewing from the perspective of the object, then you wouldn't need a negative
                                                                              // however, we need a negative sign to make it rotate in the opposite direction to make it rotate
                                                                              // the correct way from our perspective looking at it
            Vector3 rotationAxis = cameraTransform.TransformDirection(Vector3.up);

            transform.Rotate(rotationAxis, rotationY, Space.World); // this is the transform of the object that this script is attached to
                                                                    // this rotation would only move left to right and not at an angle
                                                                    // rotationAxis (vertical to the camera view) is the axis the Rotate function will use to rotate around
                                                                    // rotationY tells the function how much to rotate the object, larger the number, the further the object will rotate
                                                                    // Space.World tells the function the rotation is in the world space and not the local space of the object
            
            transform.Rotate(Vector3.right, rotationX, Space.World); // rotates only directly up and down

            // After both Rotate functions run, then the object will rotate and the angle the player wants to move to object in with their mouse

            previousMousePosition = Input.mousePosition; // Since Input.GetMouseButtonDown(0) only is true when the mouse button is initially pressed down
                                                            // Therefore, this line of code needs to be there to save the current mouse position as the previous mouse position for the next frame
        }
    }
}
