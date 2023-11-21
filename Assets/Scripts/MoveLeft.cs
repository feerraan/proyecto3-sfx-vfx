using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 30f;

    private PlayerController playerControllerScript; // = null

    private void Start()
    {
        playerControllerScript = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (!playerControllerScript.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime,
                Space.World);
        }
    }
}
