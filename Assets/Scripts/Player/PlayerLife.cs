using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] int life;

    public void changeLife(int value)
    {
        life += value;

        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
