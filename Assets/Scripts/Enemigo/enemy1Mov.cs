using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1Mov : MonoBehaviour
{
    Rigidbody2D rgb;

    Vector2 dir;

    [SerializeField] float timeDelay;
    float timer;
    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();
        dir.x = 1;
    }

    private void Update()
    {
        rgb.velocity = new Vector2(dir.x, dir.y);

        changeDir();
    }

    void changeDir()
    {
        if(timer < timeDelay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            dir.x *= -1;
            timer = 0;
        }
    }
}
