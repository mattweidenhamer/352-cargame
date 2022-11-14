using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetRunOver : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private void OnTriggerEnter2D(Collider2D other) {
        spriteRenderer.sprite = newSprite;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        spriteRenderer.sprite = newSprite;
    }
    
}
