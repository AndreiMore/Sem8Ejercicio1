using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class BulletMov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField] float speed;
    [SerializeField] int damage;

    private void Update()
    {
        move();
    }

    void move()
    {
        rgb.velocity *= speed;
    }

    public int getDamage
    {
        get
        {
            return damage;
        }
    }
}
