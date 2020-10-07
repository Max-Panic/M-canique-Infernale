using System;
using System.Collections;
using System.Collections.Generic;
using MidiJack;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(kcode))
                Debug.Log("KeyCode down: " + kcode);
        }

        for (int i = 0; i < 101; i++)
        {
            if (MidiMaster.GetKeyDown(i))
            {
                Debug.Log(i);
            }
        } 
    }
}
