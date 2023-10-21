using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] int damage;

    public int getDamage
    {
        get { return damage; }
    }
}
