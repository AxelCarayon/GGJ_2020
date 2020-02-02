using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class detectTouch : MonoBehaviour
{
    [SerializeField]
    public SpriteRenderer background;

    [SerializeField]
    public Sprite blanc;

    [SerializeField]
    public Sprite noir;
    public AudioSource keydown;
    public AudioClip sound;


    public Boolean flag = true;

    private GameObject telecommande;

    private float temps;

    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        telecommande = GameObject.Find("telecommande");

        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown("m"))
            {
                keydown.PlayOneShot(sound);
            
            }

        if (telecommande == null){
            if (Input.GetKeyDown("p"))
            {
                if (flag)
                {
                    background.sprite = blanc;
                    flag = !flag;
                }else{
                    background.sprite = noir;
                    flag = !flag;
                }
            
            }
        }


    }
}
