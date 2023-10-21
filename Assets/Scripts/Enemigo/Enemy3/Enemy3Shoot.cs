using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Shoot : MonoBehaviour
{
    [SerializeField] GameObject EnemyBullet;

    Vector2 shootDir;

    [SerializeField] float shootSpeed;
    [SerializeField] float timeBtwnShoot;
    float timer;

    private void Start()
    {
        shootDir = new Vector2(-1, 0);
    }

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
            rgb1.velocity = new Vector2(shootDir.x, shootDir.y) * shootSpeed * Time.deltaTime * 10;


            GameObject bullet2 = Instantiate(EnemyBullet);
            bullet2.transform.position = transform.position;
            Rigidbody2D rgb2 = bullet2.GetComponent<Rigidbody2D>();
            rgb2.velocity = new Vector2(shootDir.x, shootDir.y) * -shootSpeed * Time.deltaTime * 10;

        }
    }
}
