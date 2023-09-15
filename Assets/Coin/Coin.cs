using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Coin : MonoBehaviour
{
    public int points = 3;
    public event Action<Coin> gaisnCoin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gaisnCoin?.Invoke(GetComponent<Coin>());
        }
    }
}
