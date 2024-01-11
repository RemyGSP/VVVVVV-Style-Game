using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class NewControls : MonoBehaviour
{
    public bool jump;
    
    public float moveValue;
    private PlayerInputActions _actions;
    public bool godMode = false;
    public UnityEvent godModeOn;
    public UnityEvent godModeOff;

    private void Awake()
    {
        _actions = new PlayerInputActions();
        _actions.Play.Move.performed += OnMove;
        _actions.Play.Move.canceled += OnStopMove;
        _actions.Play.GodMode.performed += GodModeOn;
        
    }

    public void GodModeOn(InputAction.CallbackContext c)
    {
        if (godMode)
        {
            godMode = false;
            godModeOff.Invoke();
        }
        else
        {  
            godMode = true;
            godModeOn.Invoke();
        }
    }
    private void OnMove(InputAction.CallbackContext c)
    {
            moveValue = c.ReadValue<float>();
    }

    private void OnStopMove(InputAction.CallbackContext c)
    {
        moveValue= 0;
    }

 /*    private void OnJump(InputAction.CallbackContext c)
    {
        jump = true;
    }

    private void OnStopJump(InputAction.CallbackContext c)
    {
        jump = false;
    }
 */
    private void OnEnable()
    {
        _actions.Enable();
    }

    private void OnDisable()
    {
        _actions.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if (_actions.Play.Jump.triggered)
        {
            jump = true;
        }
        else
        {
            jump= false;
        }
    }
}
