using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flasher : MonoBehaviour
{
    [SerializeField] Color firstColor;
    [SerializeField] Color secondColor;
    private TMP_Text thisMessage;
    bool isFirstcolor = true;
    void Start() {
        thisMessage = gameObject.GetComponent<TMP_Text>();
    }

    public void flash()
    {
        if (isFirstcolor){
            isFirstcolor = false;
            thisMessage.color = secondColor;
        }
        else {
            isFirstcolor = true;
            thisMessage.faceColor = firstColor;
        }
    }
}
