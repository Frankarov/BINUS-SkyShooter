using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Moveable))]
public class PlayerController : MonoBehaviour
{

    public InputHandler inputHandler;
    private Moveable moveable;


    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    void OnSetDirect(Vector2 direction)
    {
        moveable.SetDirection(direction);
    }

    void OnEnable()
    {
        inputHandler.OnSetDirectionAction += OnSetDirect;
    }

    private void OnDisable()
    {
        inputHandler.OnSetDirectionAction -= OnSetDirect;

    }

}
