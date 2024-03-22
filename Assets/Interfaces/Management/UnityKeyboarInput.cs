using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using UnityEngine;


internal class UnityKeyboarInput : MonoBehaviour, IInputSystem
{
    public Vector2 GetDirection()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            return Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return Vector2.right;
        }
        return Vector2.zero;
    }
}

