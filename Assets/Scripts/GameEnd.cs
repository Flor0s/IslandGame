using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEnd : MonoBehaviour
{
    // ff naar kijken naar conventies
    //checked wat bool doet
    private bool SciptOnWinningObject = false;

    private ActivateEndGame EndButton;
    public UnityEvent End;

    private void Start()
    {
        EndButton = FindObjectOfType<ActivateEndGame>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ThermoLiqued")
        {
            EndButton.SetEndGameActive();
            End.Invoke();
            Time.timeScale = 0;
        }
    }
}