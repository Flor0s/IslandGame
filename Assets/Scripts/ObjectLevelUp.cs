using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLevelUp : MonoBehaviour
{
    [Header("If True Objects deactivate at Level UP")]
    public bool DoDeActivate = false;

    [Header("Temp down amount")]
    public float TempDown;

    [Header("levels")]
    public GameObject[] Diffrentstages;

    [SerializeField] private int Level = 0;

    private bool IsButtonPresed;
    private Animator m_Animator;
    private GameObject m_ParticleGameObject;
    private ParticleSystem m_Particle;
    private ThermoLqued m_Thermo;
    private ButtonPresses m_ButtonPressed;
    private int m_presses = 0;

    private void Awake()
    {
        m_Thermo = FindObjectOfType<ThermoLqued>();
        m_ButtonPressed = FindObjectOfType<ButtonPresses>();
        m_Animator = GetComponent<Animator>();
        m_ParticleGameObject = GameObject.FindGameObjectWithTag("Confetti");
        m_Particle = m_ParticleGameObject.GetComponent<ParticleSystem>();
    }

    private void Start()

    {
        Level = 0;
        Diffrentstages[Level].gameObject.SetActive(true);
        IsButtonPresed = false;
    }

    private void Update()
    {
        if (IsButtonPresed)
        {
            if (Level < m_presses)
            {
                LevelUP();
            }
        }
    }

    public void LevelUP()
    {
        m_Animator.SetTrigger("ShrinkTrigger");
        m_ParticleGameObject.transform.position = gameObject.transform.position;
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
}