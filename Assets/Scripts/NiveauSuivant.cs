using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiveauSuivant : MonoBehaviour
{
    [SerializeField] private string next_level = "nom_du_prochain_niveau";
    private Collider2D collider;


    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponentInChildren<Collider2D>();

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
            print("charger "+next_level);
        }
    }
}
