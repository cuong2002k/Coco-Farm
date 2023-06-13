using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D _playerRb;
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

    }
    private void Update()
    {
        if (_isRunning)
        {
            _lastHorizontal = _horizontal;
            _lastVertical = _vertical;
            lastMotionVector = new Vector2(_lastHorizontal, _lastVertical);
        }
    }
    private void GetInput()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
        _motionVector = new Vector2(_horizontal, _vertical);
        _isRunning = _horizontal != 0 || _vertical != 0;
    }

    private void Movement()
    {
        _playerRb.velocity = _motionVector;
    }

}
