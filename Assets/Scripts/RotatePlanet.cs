using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    private Vector3 previousMousePosition; // Stores the mouse xyz position in a Vector3

    // Start is called before the first frame update
    // Start will not run unless that game object it's attached to is in the scene hierarchy and is also active and enabled
    void Start()
    {
        
    }

    // Update is called once per frame
    // Time between frames can vary so logic inside of this method should account for that for consistent behavior
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // This will check if the mouse button has been pressed down regardless if it is held down or not
        {
            previousMousePosition = Input.mousePosition; // Get the current pixel coordinates that mouse is at in a Vector3
                                                         // Then set that equal to the Vector3 previousMousePosition variable
            Debug.Log("Previous Mouse Position: " + previousMousePosition); // Prints the mouse position at the time when the mouse was clicked
        }
    }
}
