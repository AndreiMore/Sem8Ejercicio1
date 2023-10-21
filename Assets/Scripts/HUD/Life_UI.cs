using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Life_UI : MonoBehaviour
{
    [SerializeField] PlayerLife life;

    [SerializeField] TextMeshProUGUI text;

    private void Update()
    {
        int vida = life.life;

        string format = "Vida: {0}";
        text.SetText(format, vida);
    }
}
