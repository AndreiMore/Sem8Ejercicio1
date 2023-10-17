using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField] float speed;

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
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        rgb.velocity = new Vector2(hor, ver) * speed;
    }
}
