using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    HUDManager canvaManager;


    [SerializeField]
    float speed = 5f;
    [SerializeField]
    float radius = 10f;
    float moveX, moveY;

    void Start()
    {
        canvaManager = GameObject.FindGameObjectWithTag("Canvas").GetComponent<HUDManager>();
    }



    void Update()
    {

        Collider2D collision = Physics2D.OverlapCircle(transform.position, radius);
        Move();
        Interative(collision);
        PushCamera(collision);
        

    }

    void Move()
    {
        moveX = transform.position.x + Input.GetAxis("Horizontal") * (speed / 100f);
        moveY = transform.position.y + Input.GetAxis("Vertical") * (speed / 100f);

        Vector3 posAtual = new Vector3(moveX, moveY, 0);

        transform.position = posAtual;
    }

    void Interative(Collider2D col)
    {
        if (col != null && col.transform.tag == "Interative")
        {
            Interative interativeScript = col.GetComponent<Interative>();
            canvaManager.DisplayInterative(interativeScript.nameObj, interativeScript.descriptionObj);

            if (Input.GetKeyDown(KeyCode.E))
            {
                interativeScript.ExecuteInterative();
            } 
        }
        else canvaManager.DisplayInterative(" ", " ");
    }

    void PushCamera(Collider2D col)
    {
        if ( col != null && col.transform.tag == "room")
        {
            CameraController camScript = col.GetComponent<CameraController>();
            //if(camScript != null) print("peguei aquela gorda");
            camScript.CameraMove(col.transform);
            //print(col.gameObject.name);

        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, radius);

    }

}
