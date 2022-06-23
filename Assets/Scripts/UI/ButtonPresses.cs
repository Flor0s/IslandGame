using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    //Counts all the Buttons pressed
    public int m_ButtonsPresses = 0;

    [SerializeField] private ObjectLevelUp[] ObjLvl;

    public void FindObjectLVLUp()
    {
        for (int i = 0; i < ObjLvl.Length; i++)
        {
        }
        ObjLvl = FindObjectsOfType<ObjectLevelUp>();
    }

    public void ButtonPress()
    {
        for (int i = 0; i < ObjLvl.Length; i++)
        {
            ObjLvl[i].SendMessage("ButtonIsPressed");
        }
    }
}