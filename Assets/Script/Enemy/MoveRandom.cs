using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveRandom : MonoBehaviour
{
    private Moveable moveable;
    // Start is called before the first frame update
    void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    // Update is called once per frame
    void Start()
    {
        moveable.SetDirection(RandomDirection(), RandomDirection());
    }

    private float RandomDirection()
    {
        return Random.Range(-1f,1);
    }

}
