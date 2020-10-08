using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSwitcher : MonoBehaviour
{
    public Board[] boards;
    public Camera camera;
    public int boardID = 0;

    private AK.Wwise.Event playRoySleep;
    private AK.Wwise.Event stopRoySleep;
    private AK.Wwise.Event playSkittlesSleep;
    private AK.Wwise.Event stopSkittlesSleep;

    private void Start()
    {
        //boardID
    }

    public void showBoard(int id)
    {
        camera.transform.position = boards[id].getCenter();

        switch (id)
        {
            case 2:
                playRoySleep.Post(gameObject);
                stopSkittlesSleep.Post(gameObject);
                break;
            case 3:
                 playSkittlesSleep.Post(gameObject);
                stopRoySleep.Post(gameObject);
                break;
            default:
               stopRoySleep.Post(gameObject);
               stopSkittlesSleep.Post(gameObject); 
               break;
        }
        
    }
}
