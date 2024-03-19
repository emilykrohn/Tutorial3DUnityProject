using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviPiece : MonoBehaviour
{
    public Transform objectToPlace; // Will hold information on the position and rotation of object when it can be placed
    private Camera mainCam; // Used to create a ray with the start point at the camera
    bool isSelected; // Will only be true once because each envi piece instance will be placed once

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        isSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition); // Creates a ray that starts at the camera and ends at where the mouse is
            RaycastHit hitInfo;
        }
    }
}
