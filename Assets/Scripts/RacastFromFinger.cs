using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacastFromFinger : MonoBehaviour
{
    [SerializeField] private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        for (var i = 0; i < Input.touchCount; i++)
        {
            //print(i);
            //print(Input.GetTouch(i).phase);
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                SendMessagesToObjcet(Input.GetTouch(i).position);
            }
        }
    }

    private void SendMessagesToObjcet(Vector2 FingerLocation)
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(FingerLocation);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == ("UpgradeBles"))
            {
                hit.transform.gameObject.SendMessage("LevelUP");
            }
        }
    }
}