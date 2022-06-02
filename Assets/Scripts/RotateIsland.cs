using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIsland : MonoBehaviour
{
    public bool RotateWithTouch = true;
    public float rotationSpeed;

    // Start is called before the first frame update

    private void Update()
    {
        //if (RotateWithTouch)
        //{
        //    if (Input.touchCount > 0)
        //    {
        //        Touch screenTouch = Input.GetTouch(0);

        //        if (screenTouch.phase == TouchPhase.Moved)
        //        {
        //            transform.Rotate(0f, -(screenTouch.deltaPosition.y - (rotationSpeed * Time.deltaTime)), 0f);
        //        }
        //    }
        //}
        AutoRotate();
    }

    private void AutoRotate()
    {
        gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
    }
}