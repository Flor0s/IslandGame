using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacastFromFinger : MonoBehaviour
{
    [SerializeField] private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
        //buttonP = FindObjectOfType<ButtonPresses>();
    }

    private void Update()
    {
        for (var i = 0; i < Input.touchCount; i++)
        {
            print(i);
            print(Input.GetTouch(i).phase);
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                EatTheRich(Input.GetTouch(i).position);
            }
        }
    }

    private void EatTheRich(Vector2 richLocation)
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(richLocation);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.tag == ("UpgradeBles"))
            {
                hit.transform.gameObject.SendMessage("LevelUP");
            }
        }
    }
}