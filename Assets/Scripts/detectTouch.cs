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

    public Boolean flag = true;

    private GameObject telecommande;

    private float temps;

    // Update is called once per frame
    void Update()
    {
        telecommande = GameObject.Find("telecommande");
        print(Time.time);
                if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(Application.loadedLevel);
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
