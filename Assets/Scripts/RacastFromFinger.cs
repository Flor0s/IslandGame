using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacastFromFinger : MonoBehaviour
{
    [SerializeField] private Camera camera;

    private void Update()
    {
        for (var i = 0; i < Input.touchCount; i++)
        {
            print(i);
            print(Input.GetTouch(i).phase);
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                print("Raycast shot");
                Ray ray = camera.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100f))
                {
                    print(hit.transform.name);
                }
            }
        }
    }
}