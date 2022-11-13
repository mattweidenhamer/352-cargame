using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] 
public class OhNoItsAmogus : MonoBehaviour
{
    private AudioSource amogus;
    private void start(){
        amogus = GetComponent<AudioSource>();
        amogus.Play(0);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        amogus.Play(0);
        Debug.Log("Playing music");
    }
    
}
