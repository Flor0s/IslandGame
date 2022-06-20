using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLose : MonoBehaviour
{
    // ff naar kijken naar conventies
    //checked wat bool doet
    private bool SciptOnWinningObject = false;

    private ActivateEndGame LoseButton;
    public UnityEvent Lose;

    private void Start()
    {
        LoseButton = FindObjectOfType<ActivateEndGame>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ThermoLiqued")
        {
            LoseButton.SetEndGameActive();
            Lose.Invoke();
        }
    }
}