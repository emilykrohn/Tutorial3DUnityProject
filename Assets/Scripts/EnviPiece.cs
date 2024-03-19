using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviPiece : MonoBehaviour
{
    public Transform objectToPlace;
    private Camera mainCam;
    bool isSelected;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
        isSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
