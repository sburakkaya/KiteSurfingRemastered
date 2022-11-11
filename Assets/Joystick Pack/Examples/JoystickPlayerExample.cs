using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float xspeed;
    public float yspeed;
    public float controlSpeed;
    public FloatingJoystick variableJoystick;
    public Rigidbody rb;
    public float _horizontalLimit;
    public Animator _paraschuteAnim;
    public Animator _playerAnim;
    

    public void Set_Speed(float speed)
    {
        this.speed = speed;
        _paraschuteAnim.SetBool("go",true);
    }
    
    public void Set_XSpeed(float xspeed)
    {
        this.xspeed = xspeed;
    }
    
    public void Set_YSpeed(float yspeed)
    {
        this.yspeed = yspeed;
    }
    
    public void FixedUpdate()
    {
        rb.velocity = new Vector3(xspeed, yspeed, speed);
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * controlSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        rb.transform.position = new Vector3(Mathf.Clamp(transform.position.x, -_horizontalLimit, _horizontalLimit), transform.position.y, transform.position.z);
        
        if (direction.x > 0)
        {
            _playerAnim.SetBool("right",true);
            _playerAnim.SetBool("left",false);
        }

        else if (direction.x < 0)
        {
            _playerAnim.SetBool("left",true);
            _playerAnim.SetBool("right",false);
        }
        else
        {
            _playerAnim.SetBool("left",false);
            _playerAnim.SetBool("right",false);
        }
    }
}