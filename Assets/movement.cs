using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    float moveX, moveY;

    [SerializeField]
    float speed = 5f;

    void Start()
    {
        
    }


    void Update()
    {

        Move();
    }

    void Move()
    {
        moveX = transform.position.x + Input.GetAxis("Horizontal") * (speed / 100f);
        moveY = transform.position.y + Input.GetAxis("Vertical") * (speed / 100f);

        Vector3 posAtual = new Vector3(moveX, moveY, 0);

        transform.position = posAtual;
    }
}
