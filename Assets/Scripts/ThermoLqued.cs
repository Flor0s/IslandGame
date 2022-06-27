using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermoLqued : MonoBehaviour
{
    [Header("Win/lose")]
    public bool allBuildingsBuilt = false;//If this is true, tentacles must light up

    public bool ThermometerFull = false;// if this is true player lost

    [Header("thermometer")]
    public float GrowAmount;//amount that the temprature rises

    public float timer;
    private float timeLeft;

    [SerializeField] private float OldThermoHeight;
    [SerializeField] private float ThermoHeight = 1;

    [Header("water")]
    public GameObject[] WaterObjects;

    [SerializeField] private int WaterNumber = 0;

    private void Start()
    {
        resetTimer();
        WaterObjects[WaterNumber].SetActive(true);
    }

    private void Update()
    {
        if (!allBuildingsBuilt && FindObjectOfType<AncoringIsland>()._grounded)
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

            ThermoHeight = gameObject.transform.localScale.y;
            if (ThermoHeight > 1.25)
            {
                UpdateWater();
            }
            resetTimer();
        }
    }

    public void CO2Down(float Co2loweramount)
    {
        gameObject.transform.localScale -= new Vector3(0, Co2loweramount, 0);
    }

    private void resetTimer()
    {
        timeLeft = timer;
    }

    public void UpdateWater()
    {
        if (ThermoHeight > OldThermoHeight + 0.18750025)
        {
            OldThermoHeight = ThermoHeight;

            if (WaterNumber <= WaterObjects.Length - 2)
            {
                WaterObjects[WaterNumber].SetActive(false);
                WaterNumber += 1;
                WaterObjects[WaterNumber].SetActive(true);
            }
        }
        if (ThermoHeight < OldThermoHeight - 0.18750025)
        {
            OldThermoHeight = ThermoHeight;
            if (WaterNumber >= 0)
            {
                WaterObjects[WaterNumber].SetActive(false);
                WaterNumber -= 1;
                if (WaterNumber <= 0)
                {
                    WaterNumber = 0;
                }
                WaterObjects[WaterNumber].SetActive(true);
            }
        }
    }
}