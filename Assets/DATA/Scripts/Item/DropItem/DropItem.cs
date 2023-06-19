using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    private Transform _playerTranform;
    private float _distanceDestroy = 0.1f;
    private float _distance = 1.5f;
    private float _speed = 10f;

    private void Start() {
        _playerTranform = GameManager.instance.player.transform;
    }

    private void Update()
    {
        float distance = Vector2.Distance(this.gameObject.transform.position, _playerTranform.position);
        if (distance <= _distanceDestroy)
        {
            Destroy(this.gameObject);
        }

        if (distance <= _distance)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, _playerTranform.position, _speed * Time.deltaTime);
        }


    }
}
