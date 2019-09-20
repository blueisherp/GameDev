using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OverheadText : MonoBehaviour
{
    TextMeshPro _txt;
    void Start()
    {
        _txt = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetText(string text)
    {
        _txt.text = text;
    }
}
