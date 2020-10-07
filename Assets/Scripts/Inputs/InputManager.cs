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

    private int _frame = 0;
    private readonly Note[] _successfulNotes = new [] {Note.Sol, Note.Si, Note.Re};
    private Note[] _currentNotes = new[] {Note.Null, Note.Null, Note.Null};
    void Update()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(kcode))
                Debug.Log("KeyCode down: " + kcode);
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
            Debug.Log("ouaaaai...");
        
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
