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
        if (!RotateWithTouch)
        {
            AutoRotate();
        }
        
        //if (TouchControls.T == 1)
        //{
        //    Touch screenTouch = Input.GetTouch(0);

        //    if (screenTouch.phase == TouchPhase.Moved)
        //    {
        //        transform.Rotate(0f, screenTouch.deltaPosition.x, 0f);
        //    }
        //}
    }

    private void AutoRotate()
    {
        gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
    }
}