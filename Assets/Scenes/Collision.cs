using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false;
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "package" && !hasPackage) {
            Debug.Log("Ran over a package");
            hasPackage = true;
            Destroy(other.gameObject, 0.1f);
        }
        else if (other.gameObject.tag == "delivery" && hasPackage) {
            Debug.Log("Delivered package");
            hasPackage = false;
            Destroy(other.gameObject, 0.1f);

        }
    }
}
