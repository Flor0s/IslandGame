using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevelUp : MonoBehaviour
{
    [Header("levels")]
    public GameObject[] Diffrentstages;

    public float growAmount;
    public float growTime;
    [SerializeField] private float timeLeft;

    public bool DeActivateObjectTurnOf = false;
    public bool DoLevelUp = false;
    [SerializeField] private int Level = 0;
    private GameObject ObjectToAnimate;
    private bool TimerON = false;

    private void Start()
    {
        Level = 0;
        Diffrentstages[Level].gameObject.SetActive(true);
        ObjectToAnimate = GameObject.FindGameObjectWithTag("Island");
    }

    private void Update()
    {
        if (DoLevelUp == true) //transition toevoegen iets van particles en the jumping via code
        {
            DoLevelUp = false;
            Vector3.Lerp(transform.localScale, transform.localScale + new Vector3(0, growAmount, 0), growTime * Time.deltaTime);
            levelUP();
        }

        if (TimerON)
        {
            Timer();
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
        timeLeft = growTime + 0.5f;
        TimerON = true;
    }

    public void Timer()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            TimerON = false;
            //Vector3.Lerp(transform.localScale, transform.localScale - new Vector3(0, growAmount, 0), growTime * Time.deltaTime);
        }
    }
}