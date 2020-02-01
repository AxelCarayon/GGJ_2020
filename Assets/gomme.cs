using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomme : MonoBehaviour
{
    
    public static bool possession = false;
    
    
    
    private Vector2 mousePos2D;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(possession);

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        print("oui");
        if (other.gameObject.name == "gomme")
        {
            Destroy(other.gameObject);
            possession = true;
        }

        

    }
}
