using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameWin : MonoBehaviour
{
    private bool SciptOnWinningObject = false;
    public UnityEvent Win;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ThermoLiqued" && SciptOnWinningObject)
        {
            Win.Invoke();
        }
    }
}