using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEnd : MonoBehaviour
{
    public GameObject ParentObject;
    public UnityEvent End;

    private ObjectLevelUp[] ObjlvlUp;
    private int ObjectsMaxLevel = 0;

    private void Start()
    {
        ObjlvlUp = ParentObject.GetComponentsInChildren<ObjectLevelUp>();
    }

    private void Update()
    {
        CheckIfObjectsMaxLvl();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ThermoLiqued")
        {
            EndGame();
        }
    }

    private void CheckIfObjectsMaxLvl()
    {
        if (ObjectsMaxLevel >= ObjlvlUp.Length - 2)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        End.Invoke();
        Time.timeScale = 0;
    }

    public void AddObjectToMaxLevel()
    {
        ObjectsMaxLevel += 1;
    }
}