using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float defaultSteerSpeed = 20f;
    float steerSpeed;
    [SerializeField] float defaultMoveSpeed = 10f;
    float moveSpeed;

    [SerializeField] float boostModifier = 2f;
    [SerializeField] float slugModifier = .5f;

    bool hasSlug = false;
    bool hasBoost = false;

    private void Start() {
        moveSpeed = defaultMoveSpeed;
        steerSpeed = defaultSteerSpeed;
    }
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
        float forwardBackwards = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount * steerSpeed);
        transform.Translate(0, forwardBackwards * moveSpeed, 0);

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "boost"){
            hasBoost = true;
            moveSpeed = defaultMoveSpeed * boostModifier;
        }
        else if (other.gameObject.tag == "obstacle"){
            hasSlug = true;
            hasBoost = false;
            moveSpeed = defaultMoveSpeed * slugModifier;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "obstacle" && hasSlug){
            hasSlug = false;
            moveSpeed = defaultMoveSpeed;
        }
    }
}
