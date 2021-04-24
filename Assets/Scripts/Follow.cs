using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {

    	if(other.tag == "Character_HitBox") {
    		follow(other.transform.gameObject);
    	}

    }

    void follow(GameObject other) {



    }

}
