using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private JoystickPlayerExample _joystickPlayerExample;
    public GameObject _openingPanel;
    public GameObject _gamePanel;
    public GameObject _losePanel;
    public GameObject _winPanel;

    private void Awake()
    {
        Application.targetFrameRate = 120;
        _joystickPlayerExample = FindObjectOfType<JoystickPlayerExample>();
    }

    public void GameStarter()
    {
        _openingPanel.SetActive(false);
        _gamePanel.SetActive(true);
        _joystickPlayerExample.Set_Speed(17);
    }

    public void GameWin()
    {
        _gamePanel.SetActive(false);
        _winPanel.SetActive(true);
        _joystickPlayerExample.Set_Speed(0);
    }

    public void CollidedObstacle()
    {
        _joystickPlayerExample.Set_Speed(0);
        _losePanel.SetActive(true);
    }
}
