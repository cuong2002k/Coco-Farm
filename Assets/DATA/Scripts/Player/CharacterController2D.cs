using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    private Animator _playerAmin;
    private float _horizontal;
    private float _vertical;
    private float _lastHorizontal;
    private float _lastVertical;
    private Vector2 _motionVector;
    public Vector2 lastMotionVector { get; private set; }
    private float _speed = 10f;
    private bool _isRunning;
    private void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerAmin = GetComponent<Animator>();
    }
    private void Update()
    {

        GetInput();
        Movement();
    }
    private void GetInput()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
        _motionVector = new Vector2(_horizontal, _vertical);
        _isRunning = _horizontal != 0 || _vertical != 0;
        _playerAmin.SetFloat("Horizontal", _horizontal);
        _playerAmin.SetFloat("Vertical", _vertical);
        _playerAmin.SetBool("Running", _isRunning);
        if (_isRunning)
        {
            _lastHorizontal = _horizontal;
            _lastVertical = _vertical;
            _playerAmin.SetFloat("LastHorizontal", _lastHorizontal);
            _playerAmin.SetFloat("LastVertical", _lastVertical);
            lastMotionVector = new Vector2(_lastHorizontal, _lastVertical);
        }
    }

    private void Movement()
    {
        _playerRb.velocity = _motionVector * _speed;
    }

}
