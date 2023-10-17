using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField] float speed;
    [SerializeField] public Vector2 playerInput;

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
    }
}
