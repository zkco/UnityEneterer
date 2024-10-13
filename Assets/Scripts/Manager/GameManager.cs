using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject characterSelectCanvas;
    public GameObject Player;
    public Transform playerTransform;
    public Text TimeTxt;

    private GameController controller;

    private void Awake()
    {
        if (Instance != null) return;
        Instance = this;

        if(characterSelectCanvas.activeSelf == false)
        {
            characterSelectCanvas.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        playerTransform = Player.transform;
    }

    private void Update()
    {
        CurrentTime();
    }
    private void CurrentTime()
    {
        TimeTxt.text = DateTime.Now.ToString("HH:mm");
    }
}
