using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    private Collider2D collider;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponentInChildren<Collider2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
