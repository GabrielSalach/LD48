using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    int speed;
    Rigidbody2D rb;
    Vector3 velocityVector;

    // Start is called before the first frame update
    void Start() {

        speed = 5;

        rb = gameObject.GetComponent<Rigidbody2D>();

        velocityVector = new Vector3(0,0,0);
    
    }

    // Update is called once per frame
    void Update() {

        // Récupération des touches de déplacement
        if(Input.GetKey(KeyCode.DownArrow)) {
            
            velocityVector.y = - speed;
        
        }
        else if(Input.GetKey(KeyCode.UpArrow)) {
            
            velocityVector.y = speed;
        
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) {

            velocityVector.x = -speed;

        }
        else if(Input.GetKey(KeyCode.RightArrow)) {

            velocityVector.x = speed;

        }

        // Application du déplacement
        rb.velocity = velocityVector;

        // Reset du vecteur de transformation
        velocityVector.x = 0;
        velocityVector.y = 0;
        velocityVector.z = 0; 

    }
}
