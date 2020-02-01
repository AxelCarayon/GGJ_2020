using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encre : MonoBehaviour
{
    private Vector2 mousePos2D;
    private Vector3 mousePos;

    

    void DestroyComponent()
    {
        // Supprime le corps rigide de l'objet de jeu
        Destroy(GetComponent<Rigidbody>());
    }

    
    void OnMouseDown()
    {   
        if (gomme.possession == true)
        Destroy(gameObject);

    }


    
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos2D = new Vector2(mousePos.x, mousePos.y);
        
    }
}
