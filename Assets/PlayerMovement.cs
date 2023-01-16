using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    private bool isJump = false;
    private Vector2 Movment = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        Movment = context.ReadValue<Vector2>();
    }

    public void onJump(InputAction.CallbackContext context) 
    {
        isJump = context.action.triggered;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Movment.x * runSpeed;

        
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isJump);

    }
}
