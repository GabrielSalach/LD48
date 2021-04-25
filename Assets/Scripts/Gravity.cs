using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    
	Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    void OnTriggerEnter2D(Collider2D other) {

    	if((other.tag == "Character_HitBox") || (other.tag == "Ennemy")) {
    		
    		rb = other.transform.parent.gameObject.GetComponent<Rigidbody2D>();
    		rb.gravityScale = 1;

    	}

    }

    void OnTriggerExit2D(Collider2D other) {

    	if((other.tag == "Character_HitBox") || (other.tag == "Ennemy")) {

    		rb = other.transform.parent.gameObject.GetComponent<Rigidbody2D>();
    		rb.gravityScale = 0;

    	}

    }

}
