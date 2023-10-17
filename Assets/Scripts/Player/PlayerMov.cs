using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField] float speed;
    [SerializeField] public Vector2 playerInput;

    [NonSerialized] public Vector2 dir;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement();
    }
    void movement()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");

        rgb.velocity = playerInput * speed;


        //Guardar la ultima direccion para el disparo
        if(playerInput.x != 0 || playerInput.y != 0)
        {
            dir = playerInput;
        }
    }
}
