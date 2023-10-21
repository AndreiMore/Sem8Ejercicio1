using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Mov : MonoBehaviour
{
    Rigidbody2D rgb;

    Vector2 dir;

    [SerializeField] float speed;
    [SerializeField] float timeDelay;
    float timer;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();
        dir.y = 1;
    }

    private void Update()
    {
        rgb.velocity = new Vector2(dir.x, dir.y) * speed;

        changeDir();
    }

    void changeDir()
    {
        if (timer < timeDelay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            dir.y *= -1;
            timer = 0;
        }
    }
}
