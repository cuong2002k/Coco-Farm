using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject player;
    private void Start()
    {
        instance = this;

        if(this.player == null) Debug.Log("Player in " + this.gameObject.name + " is null");
    }

    
}
