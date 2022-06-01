using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AncoringIsland : MonoBehaviour
{
    public float YOfset = 0.5f;
    [SerializeField] private Transform raycastPos;
    [SerializeField] private bool _grounded = false;

    private void Update()
    {
        if (!_grounded)
        {
            FindGround();
        }
    }

    private void FindGround()
    {
        RaycastHit hit;
        if (Physics.Raycast(raycastPos.position, transform.TransformDirection(Vector3.down), out hit))
        {
            transform.position = hit.transform.position + new Vector3(0, YOfset, 0);
            _grounded = true;
        }
    }
}