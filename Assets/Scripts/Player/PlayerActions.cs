﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E)) // TODO: Use Unity's input UI instead
        {
            G.PlayerText.SetText("Looking for object...");
            Interactable inter = FindClosestInteractable();
            inter?.Interact();
        }
    }

    Interactable FindClosestInteractable()
    {
        // TODO: implement this
        return null;
    }
}
