using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumpadCode : MonoBehaviour
{
    public Sprite[] digits;
    public Sprite[] code;

    private int _digitCount;
    
    // Start is called before the first frame update
    void Start()
    {
        ResetCode();
        _digitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetCode()
    {
        for (int i = 0; i < code.Length; i++)
        {
            code[i] = digits[0];
        }
    }

    public void addDigit(int digitID)
    {
        switch (_digitCount)
        {
            case 0:
                //code[0] = 
        }
    }
}
