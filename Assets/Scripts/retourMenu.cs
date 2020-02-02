using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retourMenu : MonoBehaviour
{
    private Vector2 mousePos2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("menu2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
