using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Teleporteur : MonoBehaviour
{
    private Collider2D collider;
    private string noTeleporteur;

    public Boolean activate;

    // Start is called before the first frame update
    void Start()
    {
        activate = false;
        print("activate : " + activate);
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
            if (this.gameObject.name == "teleporteur02")
            {
                Vector3 arrivee = GameObject.Find("Step2").transform.position;
                GameObject.Find("Player").transform.position= arrivee;
                print("activate : " + activate);

            }else if(this.gameObject.name == "teleporteurDepart0"){
                Vector3 arrivee = GameObject.Find("teleporteurArrivee0").transform.position;
                GameObject.Find("Player").transform.position= arrivee;
            }else if(this.gameObject.name == "teleporteur13"){
                Vector3 arrivee = GameObject.Find("Step3").transform.position;
                GameObject.Find("Player").transform.position= arrivee;
            }else if(this.gameObject.name == "teleporteur22"){
                Vector3 arrivee = GameObject.Find("Step4").transform.position;
                GameObject.Find("Player").transform.position= arrivee;
                Destroy(GameObject.Find("Mace"));
            }else if(this.gameObject.name == "teleporteur20"){
                if (GameObject.Find("Mace") != null)
                {
                    Vector3 arrivee = GameObject.Find("Lose").transform.position;
                    GameObject.Find("Player").transform.position= arrivee;
                }else{
                    Vector3 arrivee = GameObject.Find("Step5").transform.position;
                    GameObject.Find("Player").transform.position= arrivee;
                }
                
            }else{
                Vector3 arrivee = GameObject.Find("Lose").transform.position;
                GameObject.Find("Player").transform.position= arrivee;
            }
            
        }
    }
}
