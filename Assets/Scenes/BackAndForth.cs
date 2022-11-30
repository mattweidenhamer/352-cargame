using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    [SerializeField] float xDirection = 0f;
    [SerializeField] float yDirection = 0f;
    [SerializeField] float xSpeed = 0f;
    [SerializeField] float ySpeed = 0f;
    private float timer = 0f;
    [SerializeField] float durationBeforeTurnAround = 0f;
    private float modifier = 1f;

    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(xSpeed * modifier * Time.deltaTime, ySpeed * modifier * Time.deltaTime, 0);
        transform.Rotate(xDirection * modifier * Time.deltaTime, yDirection * modifier * Time.deltaTime, 0);
        if (timer > durationBeforeTurnAround){
            timer = 0f;
            modifier *= -1;
        }
    }
}
