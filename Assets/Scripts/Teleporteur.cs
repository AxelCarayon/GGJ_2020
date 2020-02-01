using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporteur : MonoBehaviour
{
    private Collider2D collider;
    private string noTeleporteur;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponentInChildren<Collider2D>();
        noTeleporteur = this.name.Substring(this.name.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            Vector3 arrivee = GameObject.Find("teleporteurArrivee" + noTeleporteur).transform.position;
            GameObject.Find("Player").transform.position= arrivee;
        }
    }
}
