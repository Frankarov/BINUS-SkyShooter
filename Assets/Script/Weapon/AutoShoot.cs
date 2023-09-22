using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{


    private void Update()
    {
        foreach (Weapon w in GetComponentsInChildren<Weapon>())
        {
            w.shoot();
        }
    }
}
