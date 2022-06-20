using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateEndGame : MonoBehaviour
{
    public GameObject Endgame;

    public void SetEndGameActive()
    {
        Endgame.SetActive(true);
    }
}