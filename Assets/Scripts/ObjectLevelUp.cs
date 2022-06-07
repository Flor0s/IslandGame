using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevelUp : MonoBehaviour
{
    public bool DeActivateObjectTurnOf = false;
    [SerializeField] private int Level = 0;

    [Header("Temp down amount")]
    public float TempDown;

    [Header("levels")]
    public GameObject[] Diffrentstages;

    private Animator m_Animator;
    private ThermoLqued m_Thermo;
    private ParticleSystem Particle;

    private void Start()
    {
        Level = 0;
        Diffrentstages[Level].gameObject.SetActive(true);
        m_Animator = GetComponent<Animator>();
        m_Thermo = FindObjectOfType<ThermoLqued>();
        Particle = gameObject.transform.Find("Confetti").GetComponent<ParticleSystem>();
    }

    public void LevelUP()
    {
        m_Animator.SetTrigger("ShrinkTrigger");
        Particle.Play();

        if (DeActivateObjectTurnOf == true)
        {
            Diffrentstages[Level].gameObject.SetActive(false);
        }
        Level++;
        Diffrentstages[Level].gameObject.SetActive(true);
        m_Thermo.CO2Down(TempDown);
    }
}