using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    bool isInsideSafeBox = false;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() {}

    void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Character_SafeBox") {
            isInsideSafeBox = true;
        }
        else {
            isInsideSafeBox = false;
        } 

        if(other.tag == "Character_HitBox") {
            if(!isInsideSafeBox) {
                Hit();
            }
        }

    }

    void Hit() {}

}
