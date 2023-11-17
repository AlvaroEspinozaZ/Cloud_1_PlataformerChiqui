using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawMeteorito : MonoBehaviour
{
   [SerializeField] private GameObject meteorito;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*IEnumerator SpwamMeteoritos()
    {
       yield return new WaitForSeconds(2);
        Instantiate(meteorito,transform.position,Quaternion.identity,transform.position);
    }*/
}
