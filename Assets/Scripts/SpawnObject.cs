using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    private GameManager gm;
    public int cost;
    
    // Start is called before the first frame update
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
    }

    public void Spawn(GameObject objectToSpawn)
    {
        if(gm.gold >= cost) // if player has enough gold
        {
            Instantiate(objectToSpawn); // Spawn object in parameter
            gm.gold -= cost; // Decrease the amount of gold the player has by how much the object costs
        }
    }
}
