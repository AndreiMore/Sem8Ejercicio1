using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Enemy4Mov : MonoBehaviour
{
    float angle;

    private void Update()
    {
        angle += Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
