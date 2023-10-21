using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Shoot : MonoBehaviour
{
    [SerializeField] GameObject EnemyBullet;

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

            GameObject bullet1 = Instantiate(EnemyBullet);
            bullet1.transform.position = transform.position;
            Rigidbody2D rgb1 = bullet1.GetComponent<Rigidbody2D>();
            rgb1.velocity = new Vector2(0, 1) * shootSpeed * Time.deltaTime * 10;

            GameObject bullet2 = Instantiate(EnemyBullet);
            bullet2.transform.position = transform.position;
            Rigidbody2D rgb2 = bullet2.GetComponent<Rigidbody2D>();
            rgb2.velocity = new Vector2(-1, -1) * shootSpeed * Time.deltaTime * 10;

            GameObject bullet3 = Instantiate(EnemyBullet);
            bullet3.transform.position = transform.position;
            Rigidbody2D rgb = bullet3.GetComponent<Rigidbody2D>();
            rgb.velocity = new Vector2(1, -1) * shootSpeed * Time.deltaTime * 10;
        }
    }
}
