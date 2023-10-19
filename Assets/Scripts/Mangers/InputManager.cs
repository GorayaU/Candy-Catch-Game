using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Controls _controls;

    public static void Init(Player myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector2>());
        };
    }
    public static void GameMode()
    {
        _controls.Game.Enable();
    }
}
