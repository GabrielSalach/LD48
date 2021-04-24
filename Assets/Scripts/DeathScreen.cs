using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{

    [SerializeField] GameObject screen;
    [SerializeField] Image deathScreen;
    Text text;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.Find("Death");
        deathScreen = screen.GetComponent<Image>();
        text = screen.GetComponentInChildren<Text>();
        deathScreen.enabled = true;
        text.enabled = true;
        deathScreen.canvasRenderer.SetAlpha(0);
        text.canvasRenderer.SetAlpha(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == true)
        {
            text.CrossFadeAlpha(1, 1, false);
            deathScreen.CrossFadeAlpha(1, 1, false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ennemy")
        {
            isDead = true;
        }
    }

}
