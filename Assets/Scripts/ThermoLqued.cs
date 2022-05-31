using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermoLqued : MonoBehaviour
{
    public bool allBuildingsBuilt = false;
    public float GrowAmount;//amount that the temprature rises
    public float ShrinkAmount;//amount that the temprature goes down
    public float timer;
    private float timeLeft;

    private void Start()
    {
        resetTimer();
    }

    private void Update()
    {
        if (!allBuildingsBuilt)
        {
            CO2Up();
        }
    }

    public void CO2Up()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            gameObject.transform.localScale += new Vector3(0, GrowAmount, 0);
            resetTimer();
        }
    }

    public void CO2Down()
    {
        gameObject.transform.localScale -= new Vector3(0, ShrinkAmount, 0);
    }

    private void resetTimer()
    {
        timeLeft = timer;
    }
}