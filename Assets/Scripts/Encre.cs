using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encre : MonoBehaviour
{
    private Vector2 mousePos2D;
    private Vector3 mousePos;
    private GameObject gomme;

    public AudioSource encreSound;

    

    
    void OnMouseDown()
    {   
        if (gomme == null){
            encreSound.Play();
            Destroy(gameObject);

        }
       

    }


    
    void Update()
    {
        gomme = GameObject.Find("gomme");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos2D = new Vector2(mousePos.x, mousePos.y);
        
    }
}
