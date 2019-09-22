using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Global helper class - many will say this is bad form. It may be. But it's useful.
public static class G // : MonoBehaviour
{
    static Lazy<OverheadText> _playerText = new Lazy<OverheadText>(() => {
        return GameObject.Find("PlayerOverheadText").GetComponent<OverheadText>();
    });
    public static OverheadText PlayerText => _playerText.Value;
}
    
