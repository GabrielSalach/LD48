using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class BetterMovement : MonoBehaviour
{

    [SerializeField] int speed = 50;
    Rigidbody2D rb;
    SpriteRenderer sr;

    Light2D light;
    // Vector3 currentPosition;
    // Vector3 lastPosition;
    // Vector3 delta;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        light = GetComponent<Light2D>();

        // lastPosition = transform.position;
        // delta = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {

        // currentPosition = transform.position;
        // delta = lastPosition - currentPosition;

        // light.pointLightInnerRadius -= delta.y / 15;
        // light.pointLightOuterRadius -= delta.y / 15;


        light.pointLightOuterRadius = (transform.position.y - 25) / 10;
        light.pointLightInnerRadius = light.pointLightOuterRadius - 2;

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
        
        // lastPosition = transform.position;

    }
}
