using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldDisplay;
    public GameObject planet;

    // Update is called once per frame
    private void Update()
    {
        goldDisplay.text = gold.ToString();
    }
}
