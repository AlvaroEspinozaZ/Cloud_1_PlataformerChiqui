using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cuchilla : MonoBehaviour
{
    public int empuje; 

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            collision.GetComponent<Rigidbody2D>().velocity= new Vector2(0,0);
            collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        }
    }
}
