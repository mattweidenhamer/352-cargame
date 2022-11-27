using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{


    [SerializeField] Color hasPackageColor = new Color(1, 1, 1, 1);
    [SerializeField] Color noPackageColor = new Color(1, 1, 1, 1);

    Sprite spriteDefault;
    SpriteRenderer spriteRenderer;

    bool hasPackage = false;
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteDefault = spriteRenderer.sprite;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "package" && !hasPackage) {
            Debug.Log("Gathered package");
            hasPackage = true;
            Destroy(other.gameObject, 0.1f);
            spriteRenderer.color = hasPackageColor;
        }
        else if (other.gameObject.tag == "delivery" && hasPackage) {
            Debug.Log("Delivered package");
            hasPackage = false;
            Destroy(other.gameObject, 0.1f);
            spriteRenderer.color = noPackageColor;

        }



    }
}
