using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] int life;
    [SerializeField] int toPlayerDamage;

    public void changeLife(int value)
    {
        life += value;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public int getDamgeToPlayer
    {
        get { return toPlayerDamage; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BulletPLayer"))
        {
            changeLife(-collision.GetComponent<BulletMov>().getDamage);
            Destroy(collision.gameObject);
        }
    }
}
