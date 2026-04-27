using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    private float moveSpeed = 7f;
    private bool isWalking;
    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);
        if (GameInput.Instance.IsUpPressed())
        {
            inputVector.y = 1;
        }
        if (GameInput.Instance.IsDownPressed())
        {
            inputVector.y = -1;
        }
        if (GameInput.Instance.IsLeftPressed())
        {
            inputVector.x = -1;
        }
        if (GameInput.Instance.IsRightPressed())
        {
            inputVector.x = 1;
        }
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
        float rotatoSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotatoSpeed);
        isWalking = moveDir != Vector3.zero;
        inputVector = inputVector.normalized;
    }
    public bool IsWalking()
    {
        return isWalking;
    }
}
