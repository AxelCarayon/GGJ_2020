using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gomme : MonoBehaviour
{
    
    public static bool possession = false;
       [SerializeField]
    public SpriteRenderer background;
    [SerializeField]
    public Sprite noir;
    
    
    private Vector2 mousePos2D;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        //print(this.gameObject.name);
        
        if (this.gameObject.name == "gomme")
        {
            Destroy(this.gameObject);
            possession = true; 
        }

        if (this.gameObject.name == "telecommande")
        {
            Destroy(this.gameObject);
            possession = true; 
            background.sprite = noir;
        }


        

    }
}
