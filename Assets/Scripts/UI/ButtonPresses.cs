using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    //Counts all the Buttons pressed
    public int m_ButtonsPresses = 0;

    //[SerializeField] private ObjectLevelUp[] ObjLvl;
    [SerializeField] private List<ObjectLevelUp> ObjLvl;

    [SerializeField] private List<ObjectLevelUp> EmptyObjLvl;

    private void Awake()
    {
        ObjLvl = new List<ObjectLevelUp>();
    }

    public void FindObjectLVLUp()
    {
        // hier zit het probleem dus hier moet je zoek
        if (ObjLvl.Count <= 0)
        {
            ObjLvl.AddRange(GameObject.FindObjectsOfType<ObjectLevelUp>());
        }
        else
        {
            FindObjectLVLUp();
        }
    }

    public void EmptyList()
    {
        ObjLvl.RemoveRange(0, ObjLvl.Count);
    }

    public void ButtonPress()
    {
        for (int i = 0; i < ObjLvl.Count; i++)
        {
            ObjLvl[i].SendMessage("ButtonIsPressed");
        }
    }
}