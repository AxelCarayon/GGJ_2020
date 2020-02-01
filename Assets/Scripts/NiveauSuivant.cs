using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NiveauSuivant : MonoBehaviour
{
    [SerializeField] private string next_level = "aucun";
    private Collider2D collider;


    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponentInChildren<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
            if (!next_level.Equals("aucun"))
            {
                if(next_level.Equals("reset")){
                    Application.LoadLevel(Application.loadedLevel);
                }
                if (collision.gameObject.name == "Player"){
                    SceneManager.LoadScene(next_level);
                }
            }
    }
}
