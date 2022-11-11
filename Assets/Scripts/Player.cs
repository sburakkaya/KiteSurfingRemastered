using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager _gameManager;
    private JoystickPlayerExample _joystickPlayerExample;
    private Rigidbody _rb;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _joystickPlayerExample = FindObjectOfType<JoystickPlayerExample>();
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            _gameManager.CollidedObstacle();
            _rb.constraints = RigidbodyConstraints.None;
            _joystickPlayerExample.Set_YSpeed(20);
        }

        if (collision.gameObject.CompareTag("LeftObs"))
        {
            _gameManager.CollidedObstacle();
            _rb.constraints = RigidbodyConstraints.None;
            _joystickPlayerExample.Set_XSpeed(20);
            _joystickPlayerExample.Set_YSpeed(6);
        }
        if (collision.gameObject.CompareTag("RightObs"))
        {
            _gameManager.CollidedObstacle();
            _rb.constraints = RigidbodyConstraints.None;
            _joystickPlayerExample.Set_XSpeed(-20);
            _joystickPlayerExample.Set_YSpeed(6);
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            _gameManager.GameWin();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.GetComponent<Coin>().Collected();
        }
    }
}
