using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    private Animator _animator;
    private Transform _transform;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundLayer;

    private float _horizontal;
    private float _speed = 18f;
    private int _gravity = 12;
    private bool _isFacingRight = true;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _transform = transform;
        _rb.gravityScale = _gravity;
    }

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        Flip();

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0)) && IsGrounded())
        {
            _isFacingRight = !_isFacingRight;
            _transform.Rotate(0, 0, 180);
            _gravity *= -1;
            _rb.gravityScale = _gravity;
        }

        _animator.SetBool("secorre", _horizontal != 0);
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_horizontal * _speed, _rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(_groundCheck.position, 0.2f, _groundLayer);
    }

    private void Flip()
    {
        if ((_isFacingRight && _horizontal < 0f) || (!_isFacingRight && _horizontal > 0f))
        {
            _isFacingRight = !_isFacingRight;
            Vector3 localScale = _transform.localScale;
            localScale.x *= -1f;
            _transform.localScale = localScale;
        }
    }
}
