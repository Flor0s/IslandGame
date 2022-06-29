using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevelUp : MonoBehaviour
{
    public ParticleSystem m_Particle;

    [Header("Turn of game object")]
    [Tooltip("If this bool is set to true, the game objects wil be turned of when leveling up")]
    public bool DoDeActivate = false;

    [Header("Temp down amount")]
    [Tooltip("The number in this float is the amount the temprature sinks")]
    public float TempDown;

    [Header("levels")]
    [Tooltip("every child must be in this array in order to level up")]
    public GameObject[] Diffrentstages;

    private int Level = 0;

    private bool IsButtonPresed;
    private Animator m_Animator;
    private bool ObjectMaxLevel;
    private ThermoLqued m_Thermo;
    public GameEnd GameEnd;

    private void Awake()
    {
        m_Thermo = FindObjectOfType<ThermoLqued>();
        m_Animator = GetComponent<Animator>();
    }

    private void Start()

    {
        Level = 0;
        Diffrentstages[Level].gameObject.SetActive(true);
        IsButtonPresed = false;
    }

    public void LevelUP()
    {
        if (Level <= Diffrentstages.Length - 2)
        {
            m_Animator.SetTrigger("ShrinkTrigger");
            m_Particle.Play();

            if (DoDeActivate)
            {
                Diffrentstages[Level].gameObject.SetActive(false);
            }

            Level++;
            Diffrentstages[Level].gameObject.SetActive(true);
            m_Thermo.CO2Down(TempDown);

            if (!IsButtonPresed) IsButtonPresed = true;
        }
        else
        {
            if (!ObjectMaxLevel)
            {
                GameEnd.AddObjectToMaxLevel();
                ObjectMaxLevel = true;
            }
        }
    }
}