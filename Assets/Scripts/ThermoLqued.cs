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

    private float _oldThermoHeight;
    private float _thermoHeight = 1;

    [Header("water")]
    public GameObject[] WaterObjects;

    private int _waterNumber = 0;

    private void Start()
    {
        resetTimer();
        WaterObjects[_waterNumber].SetActive(true);
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

            _thermoHeight = gameObject.transform.localScale.y;
            if (_thermoHeight > 1.25)
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
        if (_thermoHeight > _oldThermoHeight + 0.18750025)
        {
            _oldThermoHeight = _thermoHeight;

            if (_waterNumber <= WaterObjects.Length - 2)
            {
                WaterObjects[_waterNumber].SetActive(false);
                _waterNumber += 1;
                WaterObjects[_waterNumber].SetActive(true);
            }
        }
        if (_thermoHeight < _oldThermoHeight - 0.18750025)
        {
            _oldThermoHeight = _thermoHeight;
            if (_waterNumber >= 0)
            {
                WaterObjects[_waterNumber].SetActive(false);
                _waterNumber -= 1;
                if (_waterNumber <= 0)
                {
                    _waterNumber = 0;
                }
                WaterObjects[_waterNumber].SetActive(true);
            }
        }
    }
}