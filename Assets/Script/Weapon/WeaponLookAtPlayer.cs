using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLookAtPlayer : MonoBehaviour
{

    private void Update()
    {
        lookAtPlayer();
    }


    void lookAtPlayer()
    {
        if(MyCode.GameManager.GetInstance().activePlayer != null)
        {
            transform.up = MyCode.GameManager.GetInstance().activePlayer.transform.position - transform.position;
        }
    }

}
