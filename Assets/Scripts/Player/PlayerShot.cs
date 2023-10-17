using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] GameObject bullet1;
    [SerializeField] GameObject bullet2;

    bool mainBullet = true;

    private void Update()
    {
        //Cambiar de bala
        if(Input.GetKeyDown(KeyCode.Q))
        {
            mainBullet = !mainBullet;
        }

        shoot(); //void de disparo
    }

    void shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (mainBullet) //instanciar bala 1
            {
                GameObject obj = Instantiate(bullet1);
                obj.transform.position = transform.position;
            }
            else //instanciar bala 2
            {
                GameObject obj = Instantiate(bullet2);
                obj.transform.position = transform.position;
            }
        }
    }
}
