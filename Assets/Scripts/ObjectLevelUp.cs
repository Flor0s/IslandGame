using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevelUp : MonoBehaviour
{
    public bool DeActivateObjectTurnOf = false;
    public bool DoLevelUp = false;
    [SerializeField] private int Level = 0;

    [Header("levels")]
    public GameObject[] Diffrentstages;

    private Animator m_Animator;

    private void Start()
    {
        Level = 0;
        Diffrentstages[Level].gameObject.SetActive(true);
        m_Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (DoLevelUp == true) //transition toevoegen iets van particles en the jumping via code
        {
            DoLevelUp = false;
            m_Animator.SetBool("DoGrowShrink", true);
            LevelUP();
        }
    }

    public void LevelUP()
    {
        m_Animator.SetTrigger("ShrinkTrigger");
        if (DeActivateObjectTurnOf == true)
        {
            Diffrentstages[Level].gameObject.SetActive(false);
        }
        Level++;
        Diffrentstages[Level].gameObject.SetActive(true);
    }
}