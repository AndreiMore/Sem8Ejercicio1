using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] int life;

    public void changeLife(int value)
    {
        life += value;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
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
