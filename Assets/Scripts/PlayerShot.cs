using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    PlayerMov mov;

    [Header("Prefabs")]
    [SerializeField] GameObject bullet1;
    [SerializeField] GameObject bullet2;

    [SerializeField] Vector2 dir;

    bool mainBullet = true;

    private void Awake()
    {
        mov = GetComponent<PlayerMov>();
    }
    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Q))
        {
            mainBullet = !mainBullet;
        }


        shootdir();
        shoot();
    }

    void shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (mainBullet)
            {
                GameObject obj = Instantiate(bullet1);
                obj.transform.position = transform.position;

                Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                rb.velocity = dir;
            }
            else
            {
                GameObject obj = Instantiate(bullet2);
                obj.transform.position = transform.position;

                Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                rb.velocity = dir;
            }
        }
    }

    void shootdir()
    {
        dir = mov.playerInput;
    }
}
