using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevelUp : MonoBehaviour
{
    [Header("levels")]
    public GameObject[] Diffrentstages;

    public float growAmount;
    public float growTime;

    public bool DeActivateObjectTurnOf = false;
    public bool DoLevelUp = false;
    [SerializeField] private int Level = 0;

    private void Start()
    {
        Level = 0;
        Diffrentstages[Level].gameObject.SetActive(true);
    }

    private void Update()
    {
        if (DoLevelUp == true) //transition toevoegen iets van particles en the jumping via code
        {
            DoLevelUp = false;
            transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale + new Vector3(0, growAmount, 0), growTime * Time.deltaTime);
            levelUP();
        }
    }

    public void levelUP()
    {
        if (DeActivateObjectTurnOf == true)
        {
            Diffrentstages[Level].gameObject.SetActive(false);
        }
        Level++;
        Diffrentstages[Level].gameObject.SetActive(true);
        // transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale - new Vector3(0, growAmount, 0), growTime * Time.deltaTime);
    }
}