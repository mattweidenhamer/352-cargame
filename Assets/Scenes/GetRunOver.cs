using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GetRunOver : MonoBehaviour
{
    [SerializeField] bool LoseColliderOnCollision = true;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private void OnCollisionEnter2D(Collision2D other) {
        spriteRenderer.sprite = newSprite;
        other.otherCollider.enabled = !LoseColliderOnCollision;
    }
    
}
