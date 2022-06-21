using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    //Counts all the Buttons pressed
    public int m_ButtonsPresses = 0;

    private int m_OldButtonsPresses = 0;
    [SerializeField] private ObjectLevelUp[] ObjLvl;

    private void Awake()
    {
    }

    private void Update()
    {
        if (ObjLvl.Length <= 0)
        {
            FindObjectLVLUp();
        }
    }

    public void FindObjectLVLUp()
    {
        ObjLvl.SetValue(ObjLvl.Length, 0);
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