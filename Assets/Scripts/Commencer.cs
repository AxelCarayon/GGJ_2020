using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Commencer : MonoBehaviour
{
    private Vector2 mousePos2D;
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos2D = new Vector2(mousePos.x, mousePos.y);

    }
    public void Commence()
    {
<<<<<<< Updated upstream
        SceneManager.LoadScene("SampleScene");
=======
        
>>>>>>> Stashed changes

    }
    public void Credits()
    {
<<<<<<< Updated upstream
        //SceneManager.LoadScene(next_level);
=======
        
>>>>>>> Stashed changes
    }
}
