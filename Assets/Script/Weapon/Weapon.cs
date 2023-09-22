using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{


    public float fireRate;
    private float timer = 0;
    public PoolObjectType type;


    // Update is called once per frame
    void Update()
    {

        if(timer - Time.deltaTime > 0)
        {
            timer = timer - Time.deltaTime;
        }
        else
        {
            timer = 0;
        }


    }

    public void shoot()
    {
        if(timer == 0f)
        {
            Debug.Log("Nembak");
            ObjectPool.GetInstance().requestObject(type).activate(transform.position, transform.rotation);
            timer = fireRate;
        }
    }



}
