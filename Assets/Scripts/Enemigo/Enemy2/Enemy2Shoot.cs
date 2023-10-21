using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Shoot : MonoBehaviour
{
    [SerializeField] GameObject EnemyBullet;
    public Vector2 shootDir;

    [SerializeField] float shootSpeed;
    [SerializeField] float timeBtwnShoot;
    float timer;


    private void Update()
    {
        Timer();
        shootVoid();
    }

    void Timer()
    {
        timer += Time.deltaTime;
    }

    void shootVoid()
    {
        if (timer >= timeBtwnShoot)
        {
            timer = 0;

            GameObject bullet = Instantiate(EnemyBullet);
            bullet.transform.position = transform.position;

            Rigidbody2D rgb = bullet.GetComponent<Rigidbody2D>();
            rgb.velocity = new Vector2(shootDir.x, shootDir.y) * shootSpeed * Time.deltaTime * 10;

        }
    }
}

