using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaOfProtection : MonoBehaviour
{

	CircleCollider2D cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CircleCollider2D>();
        cc.radius = 7.5f;
    }

    // Update is called once per frame
    void Update()
    {
        cc.radius = transform.position.y / 10;
    }
}
