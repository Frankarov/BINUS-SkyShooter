using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour
{

    private Vector3 direction;
    public float speed = 1;

    private void Update()
    {
        UpdatePos();
    }

    private void UpdatePos()
    {
        transform.position = transform.position + direction * Time.deltaTime * speed;

    }

    public void SetDirection(Vector3 value)
    {
        direction = value;
    }

    public void SetDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }

    public void SetDirection(float x,float y)
    {
        direction.x = x;
        direction.y = y;
    }

    public Vector3 getNextPosition()
    {
        return transform.position + (direction * Time.deltaTime * speed);
    }

    internal void setXDirection(float v)
    {
        direction.x = v;
    }

    internal void setYDirection(float v)
    {
        direction.y = v;
    }

    public Vector3 newPosition()
    {
        return direction * Time.deltaTime * speed;
    }


}
