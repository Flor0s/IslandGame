using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLose : MonoBehaviour
{
    private bool SciptOnWinningObject = false;
    public UnityEvent Lose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ThermoLiqued" && !SciptOnWinningObject)
        {
            Lose.Invoke();
        }
    }
}