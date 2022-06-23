using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAtButton : MonoBehaviour
{
    public Transform _spawnPostion;
    public GameObject _prefab;

    public void Instantiate()
    {
        Instantiate(_prefab, _spawnPostion);
    }
}