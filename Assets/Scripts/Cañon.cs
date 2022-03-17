using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject laBala;
    public Transform canon;
       
    void Disparo()
    {
        Instantiate(laBala, canon.position, Quaternion.identity);
    }
    
    void Start()
    {
        Disparo();
    }

    
    void Update()
    {

    }
}
