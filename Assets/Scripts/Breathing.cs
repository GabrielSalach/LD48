using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour
{
    [SerializeField] GameObject particlePrefab;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Bubbles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Bubbles()
    {
        while(true)
        {
            Instantiate(particlePrefab, transform);
            yield return new WaitForSeconds(3f);
        }
    }
}
