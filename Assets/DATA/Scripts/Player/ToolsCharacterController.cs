using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsCharacterController : MonoBehaviour
{
    private CharacterController2D _characterCtrl;
    private Rigidbody2D _playerRb;
    private float _OfSetDistance = 1f;
    private float _sizeOfAreaInteract = 1f;


    private void Start() {
        _characterCtrl = GetComponent<CharacterController2D>();
        _playerRb = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        if(Input.GetMouseButtonDown(0))
        {
            UseTools();
        }
    }

    private void UseTools()
    {
        Vector2 position = _playerRb.position + _OfSetDistance * _characterCtrl.lastMotionVector;
        Collider2D[] collider2D = Physics2D.OverlapCircleAll(position,_sizeOfAreaInteract);
        foreach(Collider2D collider in collider2D)
        {
            TreeCutTable hit = collider.GetComponent<TreeCutTable>();
            if(hit != null)
            {
                hit.ToolHit();
                break;
            }
        }

    }
}
