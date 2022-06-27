using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AncoringIsland : MonoBehaviour
{
    [Header("Test Button")]
    public bool DoTestSpawn = false;

    public bool nietmeerzoeken;
    public bool _grounded = false;
    public float YOfset = 0.5f;
    public GameObject IslandPrefab;
    private GameObject spawnedIsland;
    [SerializeField] private Transform raycastPos;
    private ButtonPresses _BP;

    private void Start()
    {
        raycastPos = gameObject.transform.Find("AnchorIsland").GetComponent<Transform>();
        _BP = FindObjectOfType<ButtonPresses>();
    }

    private void Update()
    {
        FindGround();

        if (DoTestSpawn)
        {
            DoTestSpawn = false;
            instantiateIsland();
        }
    }

    private void FindGround()
    {
        if (_grounded) return;
        RaycastHit hit;
        if (Physics.Raycast(raycastPos.position, transform.TransformDirection(Vector3.down), out hit))
        {
            transform.position = hit.transform.position + new Vector3(0, YOfset, 0);
            _grounded = true;
            instantiateIsland();
        }
    }

    public void instantiateIsland()
    {
        spawnedIsland = Instantiate(IslandPrefab, gameObject.transform);

        _BP.FindObjectLVLUp();
    }

    public void DestroyIsland()
    {
        _BP.EmptyList();
        Destroy(spawnedIsland);
        instantiateIsland();
    }
}