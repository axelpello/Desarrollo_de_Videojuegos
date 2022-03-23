using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject laBala;
    public Transform canon;
       
    void Disparo()
    {
        if (Input.GetKeyDown(KeyCode.Space))
                    {Instantiate(laBala, canon.position, Quaternion.identity);}
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Disparo();
    }
}
