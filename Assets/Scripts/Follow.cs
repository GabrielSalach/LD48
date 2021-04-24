using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

	bool isFollowing;
	GameObject character;
	Vector3 characterPosition;
	Rigidbody2D creature;
	Vector2 velocityVector;

    // Start is called before the first frame update
    void Start()
    {
        
    	character = GameObject.FindGameObjectWithTag("Character");
    	characterPosition = character.transform.position;
    	creature = gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D>();
    	velocityVector = new Vector2(0,0);
    	isFollowing = false;

    }

    // Update is called once per frame
    void Update()
    {

    	characterPosition = character.transform.position;
    	if(isFollowing) {
    		follow();
    	}
        
    }

    void OnTriggerEnter2D(Collider2D other) {

    	if(other.tag == "Character_HitBox") {
    		isFollowing = true;
    	}

    }

    void OnTriggerExit2D(Collider2D other) {

    	if(other.tag == "Character_HitBox") {
    		isFollowing = false;
    	}

    	creature.velocity = new Vector2(0,0);

    }

    void follow() {

    	velocityVector.x = character.transform.position.x - transform.position.x;
    	velocityVector.y = character.transform.position.y - transform.position.y;

    	creature.velocity += velocityVector / 20;

    }

}
