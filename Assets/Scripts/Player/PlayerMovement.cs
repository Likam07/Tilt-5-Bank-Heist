using System.Collections;
using System.Collections.Generic;
using TiltFive;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5;
    public GameObject _player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TiltFive.Input.TryGetStickTilt(out Vector2 joystick, TiltFive.ControllerIndex.Right,
                TiltFive.PlayerIndex.One))
        {
            _player.transform.Translate(joystick.x * Time.deltaTime * movementSpeed, 0.0f,
                joystick.y * Time.deltaTime * movementSpeed);
            
            
        }
    }
    
}
