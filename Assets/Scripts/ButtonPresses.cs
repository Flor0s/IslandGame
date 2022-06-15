using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    //Counts all the Buttons pressed
    public int m_ButtonsPresses = 0;

    private int m_OldButtonsPresses = 0;
    private ObjectLevelUp ObjLvl;

    private void Awake()
    {
        ObjLvl = FindObjectOfType<ObjectLevelUp>();
    }

    public void ButtonPress()
    {
        ObjLvl.SendMessage("ButtonIsPressed", 1);
    }
}