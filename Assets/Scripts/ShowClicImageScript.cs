using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowClicImageScript : MonoBehaviour
{
    private GameObject gomme;
    public const string LAYER_NAME = "Foreground";
    public int sortingOrder = 0;
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        gomme = GameObject.Find("gomme");
        if (gomme == null){
            sprite.sortingOrder = sortingOrder;
            sprite.sortingLayerName = LAYER_NAME;
        }
        
    }
}
