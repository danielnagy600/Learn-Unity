using System.Collections;
using UnityEngine;


public class DizovulMovement : MonoBehaviour
{
    private readonly float Gravity = -10;
    private float Speed = 2;
    private float _InputVertical;

    private CharacterController _controller;
    private Vector3 _moveDirection;

    private Animator _animator;
    public Transform _mainCameraTransform;


    private int jumpHash;
    private int combo1Hash;
    private int combo2Hash;

    private bool isFight1;
    private bool isFight2;
    private bool isJump;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        _mainCameraTransform = GameObject.FindWithTag("MainCamera").transform;

        jumpHash = Animator.StringToHash("Jump");
        combo1Hash = Animator.StringToHash("isCombo1");
        combo2Hash = Animator.StringToHash("isCombo2");
    }

    void Update()
    {
        _InputVertical = Input.GetAxis("Vertical");
        isFight1 = Input.GetButton("Fire1");
        isFight2 = Input.GetButton("Fire2");

        GroundChecker();
        AttackChecker(isFight1,isFight2);

        if (isJump) Jump();
        else
        {
            _moveDirection = transform.forward * _InputVertical;
            if(_InputVertical > 0) _controller.Move(_moveDirection * Speed * Time.deltaTime);
            SetAnimation(_InputVertical);
            transform.rotation = _mainCameraTransform.rotation;
        }
    }

    private void SetAnimation(float InputZ)
    {
        _animator.SetFloat("Speed", InputZ);
    }

    private void UseGravity()
    {
        _moveDirection.y += Gravity *Speed* Time.deltaTime*40;
        _controller.Move(_moveDirection * Time.deltaTime);
    }

    private void Jump()
    {
        _animator.SetBool(jumpHash, true);
    }
 

    private void AttackChecker(bool isFight1, bool isFight2)
    {
        if (isFight1) _animator.SetBool(combo1Hash, true);
        else if(isFight2) _animator.SetBool(combo2Hash, true);
    }


    private void GroundChecker()
    {
        if (_controller.isGrounded)
        {
            _animator.SetBool(jumpHash, false);
            isJump = Input.GetButton("Jump");
        }
        else UseGravity();
    }

}
