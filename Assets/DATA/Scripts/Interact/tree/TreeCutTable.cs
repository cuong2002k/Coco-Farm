using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCutTable : Tools
{
    [SerializeField] private GameObject _item;
    private float _itemCount = 5f;
    private float _spread = 0.7f;
    private void Start() {
        
    }



    
    public override void ToolHit()
    {
        while(_itemCount > 0)
        {
            Vector2 position = this.transform.position;
            position.x += Random.value * _spread - _spread/2;
            position.y += Random.value * _spread - _spread/2;
            Instantiate(_item,position,Quaternion.identity);
            _itemCount--;
        }
        Destroy(this.gameObject);
    }
}
