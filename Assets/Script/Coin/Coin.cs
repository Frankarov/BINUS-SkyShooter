using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public myScriptableInteger coin;

    public void OnGain()
    {
        coin.value += 1;
    }

}
