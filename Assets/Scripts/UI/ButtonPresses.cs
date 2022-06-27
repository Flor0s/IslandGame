using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    //Counts all the Buttons pressed
    public int m_ButtonsPresses = 0;

    private int m_OldListCount;

    // public List<ObjectLevelUp> ObjLvl = new List<ObjectLevelUp>();

    //  public void FindObjectLVLUp()
    //  {
    // hier zit het probleem dus hier moet je zoek
    //var objects = GameObject.FindObjectsOfType<ObjectLevelUp>();

    //foreach (var l_objects in objects)
    //{
    //    ObjLvl.Add(l_objects);
    //}

    //ObjLvl.AddRange(GameObject.FindObjectsOfType<ObjectLevelUp>());

    //foreach (var obj in ObjLvl)
    //{
    //    if (obj == null) { ObjLvl.Remove(obj); }
    //}
    // }

    //    public void ButtonPress()
    //    {
    //        for (int i = 0; i < ObjLvl.Count; i++)
    //        {
    //            foreach (var obj in ObjLvl)
    //            {
    //                if (obj != null) { ObjLvl[i].SendMessage("ButtonIsPressed"); }
    //            }
    //        }
    //    }
}