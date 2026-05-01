using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }
    private GameInputAction gameInputAction;
    private void Awake()
    {
        Instance = this;
        gameInputAction = new GameInputAction();
        gameInputAction.Enable();
    }
    public Vector2 GetInputVectorNormalized()
    {
        Vector2 inputVector = gameInputAction.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
