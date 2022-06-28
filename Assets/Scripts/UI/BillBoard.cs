using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    private Transform Camera;
    private Transform MyTransform;
    public bool alignNotLook = true;

    // Use this for initialization
    private void Start()
    {
        MyTransform = this.transform;
        Camera = UnityEngine.Camera.main.transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (alignNotLook)
            MyTransform.forward = Camera.forward;
        else
            MyTransform.LookAt(Camera, Vector3.up);
    }
}