using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarPrefab : MonoBehaviour
{
    public GameObject bala;
    public Transform posicion;
    
    
    private void InstanciarBala()
    {
        Instantiate (bala, posicion.position, Quaternion.identity);
    }


    void Start()
    {
        InstanciarBala();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
