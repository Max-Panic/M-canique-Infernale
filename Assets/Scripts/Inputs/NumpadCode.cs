using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumpadCode : MonoBehaviour
{
    public Sprite[] digits;
    public SpriteRenderer[] _code;

    public int[] combination;
    private int[] _numCode = new int[3]{0, 0, 0};
    private bool _toBeReset = false;

    private float _counter;
    

    private int _digitCount;
    
    // Start is called before the first frame update
    void Start()
    {
        ResetCode();
        _digitCount = 0;
    }

    private void Update()
    {
        if (_toBeReset)
        {
            if (_counter > 1.5f)
            {
                foreach (var i in _code)
                {
                    i.color = Color.white;
                }
                ResetCode();
                _toBeReset = false;
                _counter = 0f;
            }
            else
                _counter += 1f*Time.deltaTime;
        }
        
    }

    private void ResetCode()
    {

        
        for (int i = 0; i < _code.Length; i++)
        {
            _code[i].sprite = digits[0];
            _numCode[i] = 0;
            _digitCount = 0;
        }
    }

    public bool AddDigit(int digitID)        //return true if 3 digits entered
    {
        bool complete = false;

        switch (_digitCount)
        {
            case 0:
                _code[0].sprite = digits[digitID];
                _numCode[0] = digitID;
                _digitCount++;
                break;
            case 1:
                _code[1].sprite = digits[digitID];
                _numCode[1] = digitID;
                _digitCount++;
                break;
            case 2:
                _code[2].sprite = digits[digitID];
                _numCode[2] = digitID;
                complete = true;
                break;
        }

        
        return complete;
    }

    public bool CheckDigit()
    {

        if (_numCode[0] == combination[0] && _numCode[1] == combination[1] && _numCode[2] == combination[2])
        {
            Debug.Log("Victoire par numéro");
            foreach (var i in _code)
            {
                i.color = Color.green;
            }
            return true;
        }
        else
        {
            _toBeReset = true;
            //anim
            foreach (var i in _code)
            {
                i.color = Color.red;
            }
            return false;
        }
        
        
    }
}
