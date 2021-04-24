using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        winText = GameObject.Find("Win");

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerEnter2D(Collider2D other) {

    	if(other.tag == "Character") {
            winText.GetComponent<Text>().enabled = true;
    	}

    }

}