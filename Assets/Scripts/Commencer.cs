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

        SceneManager.LoadScene("SampleScene");


    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");

    }
    public void Retour()
    {
        SceneManager.LoadScene("menu2");
    }
    public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Lv1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Lv2()
    {
        SceneManager.LoadScene("lv2");
    }
    public void Lv3()
    {
        SceneManager.LoadScene("lv3");
    }
    public void Lv4()
    {
        SceneManager.LoadScene("lv4");
    }
    public void Lv5()
    {
        SceneManager.LoadScene("lv5");
    }
    public void Lv6()
    {
        SceneManager.LoadScene("lv6");
    }
}
