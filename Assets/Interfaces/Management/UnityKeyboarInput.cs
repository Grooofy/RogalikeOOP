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
        return new Vector2();
        //Input.GetAxis("Horizontal")
    }
}

