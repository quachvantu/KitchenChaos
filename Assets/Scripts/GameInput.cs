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
    public bool IsUpPressed()
    {
        return gameInputAction.Player.Up.IsPressed();
    }
    public bool IsDownPressed()
    {
        return gameInputAction.Player.Down.IsPressed();
    }
    public bool IsLeftPressed()
    {
        return gameInputAction.Player.Left.IsPressed();
    }
    public bool IsRightPressed()
    {
        return gameInputAction.Player.Right.IsPressed();
    }
}
