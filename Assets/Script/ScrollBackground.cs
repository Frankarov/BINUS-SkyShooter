using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{

    public Transform[] background;
    public float speed;

    [Header("Camera Top")]
    public float topPosY;

    [Header("Camera Bot")]
    public float botPosY;


    void Update()
    {
        positionUpdate();

        checkPosition();
    }

    void checkPosition()
    {
        if (background[0].transform.position.y < botPosY)
        {
            background[0].transform.position = new Vector3(0, topPosY, 0);
        }
        if (background[1].transform.position.y < botPosY)
        {
            background[1].transform.position = new Vector3(0, topPosY, 0);
        }
    }

    void positionUpdate()
    {
        var movementBG = Time.deltaTime * speed;
        //Proses pemindahan map
        background[0].transform.position = new Vector3(0, background[0].position.y - movementBG, 0);
        background[1].transform.position = new Vector3(0, background[1].position.y - movementBG, 0);
    }




}
