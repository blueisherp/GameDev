using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomPlant : Interactable
{
    void Start()
    {
        
    }

    public override void Interact()
    {
        Debug.Log("Interact");
        G.PlayerText.SetText("You found a key in the plant!");
    }

    void Update()
    {
        
    }
}
