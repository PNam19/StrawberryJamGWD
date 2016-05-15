using UnityEngine;
using System.Collections;

public class InsideDorrTrigger : MonoBehaviour
{

    private bool colliding = false;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            colliding = true;
            Debug.Log("true");
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            colliding = false;
            Debug.Log("false");
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && colliding)
        {
            Application.LoadLevel(2);
        }
    }
}
