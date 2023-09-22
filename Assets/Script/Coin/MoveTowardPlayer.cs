using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyCode;

[RequireComponent(typeof(Moveable))]
public class MoveTowardPlayer : MonoBehaviour
{

    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    // Start is called before the first frame update
    void Start()
    {
        moveable.SetDirection(getDirection());
    }

    private Vector3 getDirection()
    {
        Vector3 dir;
        dir = GameManager.GetInstance().getPlayerPosition() - transform.position;
        dir = dir.normalized;
        Debug.Log(dir);
        return dir;

    }
}
