using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationArrow : MonoBehaviour
{
   public enum Direction
   {
      Right, Left
   }

   public BoardSwitcher boardSwitcher;

   public Direction direction;

   public void OnClick()
   {
      
      Debug.Log("test");
      if (direction == Direction.Left)
      {
         boardSwitcher.boardID -= 1;
      }
      
      if (direction == Direction.Right)
      {
         boardSwitcher.boardID += 1;
      }
         
   }
   

}
