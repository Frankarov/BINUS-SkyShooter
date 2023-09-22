using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectSpawnRate : MonoBehaviour
{
    [Range(1, 100)] public int rate;
    public GameObject prefab;
}
