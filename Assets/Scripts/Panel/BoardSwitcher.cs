using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSwitcher : MonoBehaviour
{
    public Board[] boards;
    public Camera camera;
    public int boardID = 0;
    private int currentBoardID = 0;

    public bool kingUnlock = false;
    
    public AK.Wwise.Event playRoySleep;
    public AK.Wwise.Event stopRoySleep;
    public AK.Wwise.Event playSkittlesSleep;
    public AK.Wwise.Event stopSkittlesSleep;

    private void Update()
    {
        if (boardID < 0)
        {
            boardID = 4;
        }
        if (boardID > 4)
        {
            boardID = 0;
        }
        
        if (boardID != currentBoardID)
        {
            if (boardID == 2)
            {
                if (kingUnlock)
                {
                    showBoard(boardID);
                    currentBoardID = boardID;
                }
                else if(currentBoardID<boardID)
                {
                    showBoard(boardID+1);
                    boardID += 1;
                    currentBoardID = boardID;
                    
                }
                else
                {
                    showBoard(boardID-1);
                    boardID -= 1;
                    currentBoardID = boardID -1;
                }
            }
            else
            {
                showBoard(boardID);
                currentBoardID = boardID;
            }
            
        }
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
