using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class PlayerLife : MonoBehaviour
{
    public int life;

    private void Update()
    {
        if(life < 0) life = 0;
    }

    public void changeLife(int value)
    {
        life += value;

        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.GetComponent<EnemyLife>() != null)
            {
                changeLife(-collision.gameObject.GetComponent<EnemyLife>().getDamgeToPlayer);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (collision.gameObject.GetComponent<EnemyBullet>() != null)
            {
                changeLife(-collision.gameObject.GetComponent<EnemyBullet>().getDamage);
                Destroy(collision.gameObject);
            }
        }
    }
}
