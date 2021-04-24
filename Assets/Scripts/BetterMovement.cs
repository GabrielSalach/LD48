using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] int speed = 50;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            rb.AddForce(-Vector3.right * speed);
            sr.flipX = true;
        }
            
        else if (Input.GetKeyDown(KeyCode.RightArrow)){
                rb.AddForce(Vector3.right * speed);
                sr.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddForce(Vector3.up * speed);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.AddForce(-Vector3.up * speed);
        

    }
}
