using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public SpriteRenderer image;
    public Transform center;

    public Vector3 getCenter()
    {
        return center.position;
    }
}
