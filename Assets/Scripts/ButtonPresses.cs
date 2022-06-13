using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPresses : MonoBehaviour
{
    //Counts all the Buttons pressed
    public int m_ButtonsPresses = 0;

    public void ButtonPress()
    {
        m_ButtonsPresses += 1;
    }
}