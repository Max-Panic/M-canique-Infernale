using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSwitcher : MonoBehaviour
{
    public Board[] boards;
    public Camera camera;

    private AK.Wwise.Event playRoySleep;
    private AK.Wwise.Event stopRoySleep;
    private AK.Wwise.Event playSkittlesSleep;
    private AK.Wwise.Event stopSkittlesSleep;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("0");
            showBoard(0);
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("1");
            showBoard(1);
        }
    }

    public void showBoard(int id)
    {
        camera.transform.position = boards[id].getCenter();

        switch (id)
        {
            //case prison:
               // playRoySleep.Post(gameObject);
                //stopSkittlesSleep.Post(gameObject);
            //break;
            //case machine:
        // playSkttlesSleep.Post(gameObject);
        //stopRoySleep.Post(gameObject);
        //break;
            //default:
               // stopRoySleep.Post(gameObject);
                //stopSkittlesSleep.Post(gameObject);
                //break;
        }
        
    }
}
