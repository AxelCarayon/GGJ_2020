using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    private Vector2 mousePos2D;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
