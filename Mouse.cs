using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mouse : MonoBehaviour
{
    public void Showmouse()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void Hidemouse()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}