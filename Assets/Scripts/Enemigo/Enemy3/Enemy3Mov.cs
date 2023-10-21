using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Enemy3Mov : MonoBehaviour
{
    Rigidbody2D rgb;

    [SerializeField] float speed;

    //CambiarDireccion
    float waitTime = 5;
    Vector2 dir;
    public bool Stay = false;

    private void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        SetNewDestination();
    }

    private void Update()
    {
        rgb.velocity = new Vector2(dir.normalized.x, dir.normalized.y) * speed;

        if(!Stay)
        {
            Stay = true;
            StartCoroutine(SetNewDestination());
        }
    }

    IEnumerator SetNewDestination()
    {
        yield return new WaitForSeconds(waitTime);

        dir = new Vector2(Random.Range(-1, 1), transform.position.y + Random.Range(-1, 1));

        Stay = false;
    }
}
