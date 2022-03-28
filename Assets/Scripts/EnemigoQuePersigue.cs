using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoQuePersigue : MonoBehaviour
{   
     
    public GameObject jugadorAPerseguir;
    private Vector3 distancia;
    public float velocidadDelEnemigo;

    void Perseguir()
    {
        this.transform.LookAt(jugadorAPerseguir.transform); //Lo mira siempre.
        distancia = jugadorAPerseguir.transform.position - this.transform.position; //Calculo la distancia.
        if (distancia.magnitude> 2f)
            {this.transform.position = Vector3.MoveTowards(this.transform.position, jugadorAPerseguir.transform.position, velocidadDelEnemigo * Time.deltaTime);}

    }
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Perseguir();
    }
}
