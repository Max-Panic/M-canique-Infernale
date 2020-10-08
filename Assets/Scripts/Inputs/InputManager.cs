using System;
using System.Collections;
using System.Collections.Generic;
using MidiJack;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private enum Note
    {
        Sol, Si, Re, Null, Other
    }

    public Animator animator; 
    
    private int _frame = 0;
    private readonly Note[] _successfulNotes = new [] {Note.Sol, Note.Si, Note.Re};
    private Note[] _currentNotes = new[] {Note.Null, Note.Null, Note.Null};

    private bool tiroir = false;
    private bool eau = false;
    private bool cle = false;
    private bool echec = false;
    private bool corde = false;
    
    void Update()
    {

        if (Input.GetKey(KeyCode.JoystickButton0))
        {
            if (!echec)
            {
                animator.SetTrigger("Chess");
                echec = true;
            }
        }

        if (Input.GetKey(KeyCode.JoystickButton1))
        {
      
            if (!tiroir)
            {
                Debug.Log("test");
                animator.SetTrigger("Tiroir");
                tiroir = true;
            }
            
        }

        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            if (!eau)
            {
                animator.SetBool("Water", true);
                eau = true;
            }
        }

        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            if (!cle)
            {
               // animator.SetTrigger("");
                cle = true;
            }
        }

        if (Input.GetKey(KeyCode.JoystickButton5))
        {
            if (!corde)
            {
                animator.SetTrigger("Rope");
                corde = true;
            }
        }
        
        FixedUpdate();

        _frame++;
    }

    private void FixedUpdate()
    {
        
        for (int i = 48; i <= 72; i++)
        {
            if (MidiMaster.GetKeyDown(i))
            {
                Debug.Log("Yo");
                AddNote(ConvertNote(i));
                CheckRiff();
            }
        } 
    }

    private static Note ConvertNote(int noteId)
    {
        Note currentNote = Note.Other;
        switch (noteId)
        {
            case 55: 
            case 67:
                //SOL
                currentNote = Note.Sol;
                break;
            case 59:
            case 71:
                //SI
                currentNote = Note.Si;
                break;
            case 50:
            case 62:
                //RE
                currentNote = Note.Re;
                break;
        }
        return currentNote;
    }

    private void AddNote(Note note)
    {
        for (var i = 0; i < _currentNotes.Length; i++)
        {
            if (_currentNotes[i] != Note.Null) continue;
            _currentNotes[i] = note;
            break;
        }
    }

    private void CheckRiff()
    {
        Debug.Log(_currentNotes[0] + " " + _currentNotes[1] + " " + _currentNotes[2]);
        bool win = true;
        for (var i = 0; i < _successfulNotes.Length; i++)
        {
            if (_currentNotes[i] == Note.Null)
            {
                win = false;
                break;
            }
            if (_successfulNotes[i] != _currentNotes[i])
            {
                ResetNotes(_currentNotes);
                win = false;
                break;
            }
        }
         
        if(win)
            animator.SetBool("Water", true);
        
    }

    private static void ResetNotes(Note[] notes)
    {
        for (int i = 0; i < notes.Length; i++)
        {
            notes[i] = Note.Null;
        }
        
        Debug.Log("HUUUUN");
    }
}
