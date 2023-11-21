using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SpawMeteorito : MonoBehaviour
{
   [SerializeField] private GameObject meteorito;

    public event Action _SpawMeteorito;

    public void SpwamMeteoritos(int direction,float velocity)
    {        
        GameObject tmp = Instantiate(meteorito, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        tmp.GetComponent<Rigidbody2D>().velocity = (Vector2.left* direction) * velocity;
        tmp.GetComponent<Cuchilla>().empuje = 90000;
    }
    public void Press()
    {
        _SpawMeteorito?.Invoke();
    }
}
