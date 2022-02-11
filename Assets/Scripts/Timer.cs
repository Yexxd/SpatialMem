using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float elapsedTime = 0;
    public TextMeshPro txtTimer;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        txtTimer.text = "Tiempo: " + elapsedTime.ToString("F1");
    }
}
