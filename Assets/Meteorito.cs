using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorito : MonoBehaviour
{
    public int empuje;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            if (collision.GetComponent<Rigidbody2D>() != null)
            {
                collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            }
            Destroy(this.gameObject,1.2f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            if (collision.GetComponent<Rigidbody2D>() != null)
            {
                collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                if (collision.gameObject.layer ==6 || collision.gameObject.tag =="Wall" )
                {
                    collision.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                }
                
            }           
            
        }
    }
}
