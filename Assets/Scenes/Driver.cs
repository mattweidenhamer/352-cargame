using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 20f;
    [SerializeField] float moveSpeed = 10f;

    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    Sprite spriteDefault;

    SpriteRenderer spriteRenderer;

    bool hasPackage;



    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteDefault = spriteRenderer.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
        float driveAmount = Input.GetAxis("Vertical") * Time.deltaTime;
        float boostAmount = Input.GetAxis("Jump");
        if (boostAmount == 1){
            boostAmount = 2;
        }
        else {
            boostAmount = 1;
        }

        transform.Translate(0, moveSpeed * driveAmount * Time.deltaTime * boostAmount, 0);
        if (driveAmount != 0){
            transform.Rotate(0, 0, -steerAmount * steerSpeed * Time.deltaTime);
        }
    }
}
