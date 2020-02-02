using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopPosition : MonoBehaviour
{
    [SerializeField] private float y_position_stop_up = 100f;
    [SerializeField] private float y_position_stop_down = -100f;
    [SerializeField] private float x_position_stop_left = -100f;
    [SerializeField] private float x_position_stop_right = 100f;
    private float positionY;
    private float positionX;
    private Rigidbody2D m_Rigidbody;
    private Vector2 mousePos2D;



    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        Debug.Log(mousePos2D);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        positionY = position.y;
        positionX = position.x;
        if (positionY >= y_position_stop_up){
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
            m_Rigidbody.gravityScale = 0.0f;
        }
        if (positionY <= y_position_stop_down)
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
            m_Rigidbody.gravityScale = 0.0f;
        }
        if (positionX <= x_position_stop_left)
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }

        if (positionX >= x_position_stop_right)
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }

        /*if (this.name == "BlocDroite1")
        {
            Debug.Log("Position X : "+ positionX + " | Limite gauche : " +x_position_stop_left + " | Limite Droite : " + x_position_stop_right) ;
        }*/

    }
}
