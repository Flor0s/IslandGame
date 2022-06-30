using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEnd : MonoBehaviour
{
    public GameObject ParentObject;

    private ActivateEndGame EndButton;
    private ObjectLevelUp[] ObjlvlUp;
    [SerializeField] private int ObjectsMaxLevel = 0;

    private void Start()
    {
        EndButton = FindObjectOfType<ActivateEndGame>();
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
        if (ObjectsMaxLevel >= ObjlvlUp.Length)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        EndButton.SetEndGameActive();
    }

    public void AddObjectToMaxLevel()
    {
        ObjectsMaxLevel += 1;
    }
}