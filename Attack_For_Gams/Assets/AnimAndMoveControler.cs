using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimAndMoveControler : MonoBehaviour
{
    public float speedWalk;

    PlayerInput PlayerInput;
    public CharacterController Controller;
    Animator animator;

    Vector2 currentMovementInput;
    Vector3 currentMovement;
    bool isMovementPressde;
    float rotationFactorPerFrame = 15f;
    void Awake()
    {
        PlayerInput = new PlayerInput();
        Controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        PlayerInput.characterControler.move.started += onMovementInput;
        PlayerInput.characterControler.move.canceled += onMovementInput;
        PlayerInput.characterControler.move.performed += onMovementInput;
    }
    void handleRotation()
    {
        Vector3 positionToLookAt;

        positionToLookAt.x = currentMovement.x;
        positionToLookAt.y = 0.0f;
        positionToLookAt.z = currentMovement.z;

        Quaternion currentRotation = transform.rotation;

        if (isMovementPressde)
        {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotationFactorPerFrame * Time.deltaTime);
        }
    }
    void onMovementInput(InputAction.CallbackContext context)
    {
        currentMovementInput = context.ReadValue<Vector2>();
        currentMovement.x = currentMovementInput.x * speedWalk;
        currentMovement.z = currentMovementInput.y * speedWalk;
        isMovementPressde = currentMovement.x != 0 || currentMovement.z != 0;
    }
    void handleAnimation()
    {
        bool isRuning = animator.GetBool("run");
        bool isWalking = animator.GetBool("walk");

        if(isMovementPressde && !isWalking)
        {
            animator.SetBool("walk", true);
        }
        if (!isMovementPressde && isWalking)
        {
            animator.SetBool("walk", false);
        }
    }
    void Update()
    {
        handleAnimation();
        handleRotation();

        Controller.Move(currentMovement * Time.deltaTime);
    }
    private void OnEnable()
    {
        PlayerInput.characterControler.Enable();
    }
    private void OnDisable()
    {
        PlayerInput.characterControler.Disable();
    }
}
