using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumpadDigit : MonoBehaviour
{

    public int numID;
    public NumpadCode numpadCode;
        
    private void OnMouseDown()
    {
        if (numpadCode.AddDigit(numID))
        {
            numpadCode.CheckDigit();
        }
    }
    
}
