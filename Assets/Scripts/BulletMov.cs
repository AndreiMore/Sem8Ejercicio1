using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class BulletMov : MonoBehaviour
{
    Rigidbody2D rgb;
    PlayerMov mov;

    [SerializeField] float speed;
    [SerializeField] int damage;

    Vector2 dir;
    private void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        mov = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMov>();

        dir = mov.dir;
    }

    private void Update()
    {
        move();
    }

    void move()
    {
        rgb.velocity = new Vector2(dir.x, dir.y) * speed * Time.fixedDeltaTime * 10;
    }

    public int getDamage
    {
        get
        {
            return damage;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
