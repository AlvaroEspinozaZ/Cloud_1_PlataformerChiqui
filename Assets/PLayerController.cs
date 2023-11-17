using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PLayerController : MonoBehaviour
{
    private Rigidbody2D rgb;
    Vector2 move;
    public float x,y;
    public float velocity;
    public float jump;
    public float life;
    [SerializeField] GameObject cuchilla;
    public event Action<PLayerController> Life_n;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent< Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        //y = Input.GetAxis("Vertical");

        move = new Vector2(x* velocity, rgb.velocity.y);
        rgb.velocity = move;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Ads");
            rgb.AddForce(Vector2.up* jump);
        }

        if (Input.GetKey(KeyCode.W))
        {
            cuchilla.SetActive(true);
        }
        else
        {
            cuchilla.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            Life_n?.Invoke(GetComponent<PLayerController>());
        }
    }
}
