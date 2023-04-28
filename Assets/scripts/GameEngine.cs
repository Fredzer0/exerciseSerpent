using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEngine : MonoBehaviour
{
    private UnityAction<object> restartLevel;
    void Start()
    {
        restartLevel = new UnityAction<object>(RestartLevel);
        EventManager.StartListening("Mort", restartLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void RestartLevel(){

    }
}
