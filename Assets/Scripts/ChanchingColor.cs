using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanchingColor : MonoBehaviour
{
    [Header("Tempreture Settings")]
    public Material[] tempreatureColors;

    public float OrangeCollor;
    public float RedCollor;

    [Header("GameObjects")]
    public GameObject ThermoBase;

    public GameObject ThermoShaft;

    private void Update()
    {
        if (gameObject.transform.localScale.y <= OrangeCollor - 0.01)
        {
            ThermoBase.GetComponent<MeshRenderer>().material = tempreatureColors[0];
            ThermoShaft.GetComponent<MeshRenderer>().material = tempreatureColors[0];
        }

        if (gameObject.transform.localScale.y >= OrangeCollor)
        {
            ThermoBase.GetComponent<MeshRenderer>().material = tempreatureColors[1];
            ThermoShaft.GetComponent<MeshRenderer>().material = tempreatureColors[1];
        }

        if (gameObject.transform.localScale.y >= RedCollor)
        {
            ThermoBase.GetComponent<MeshRenderer>().material = tempreatureColors[2];
            ThermoShaft.GetComponent<MeshRenderer>().material = tempreatureColors[2];
        }
    }
}