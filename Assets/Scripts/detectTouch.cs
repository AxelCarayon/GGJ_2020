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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown("p"))
        {
            if (flag)
            {
                background.sprite = noir;
                flag = !flag;
            }else{
                background.sprite = blanc;
                flag = !flag;
            }
           
        }

    }
}
