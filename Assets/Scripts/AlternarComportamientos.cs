using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternarComportamientos : MonoBehaviour
{
  
    
    public enum Comportamiento
    {
        Enemigo1,
        Enemigo2
    }
    public Comportamiento comportamientoElegido;

    private Quaternion rotacionQuaternion;
    public float velocidadRotacionEnemigo;//Variables del script del Enemigo 1.
    
    public float velocidadDelEnemigo;
    private Vector3 distancia; //Variables del script del Enemigo 2.

    public GameObject jugador; //Ambos scripts utilizan el mismo objetivo, que es el jugador.


    void MirarAlJugador()
    {
        rotacionQuaternion = Quaternion.LookRotation (jugador.transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Lerp(transform.rotation, rotacionQuaternion, velocidadRotacionEnemigo);    //Script del enemigo 1.
    }

    void Perseguir()
    {
        this.transform.LookAt(jugador.transform);
        distancia = jugador.transform.position - this.transform.position; 
        if (distancia.magnitude> 2f)
            {this.transform.position = Vector3.MoveTowards(this.transform.position, jugador.transform.position, velocidadDelEnemigo * Time.deltaTime);} //Script del Enemigo 2.

    }

    void AnalizarComportamientoElegido()
    {
        switch (comportamientoElegido)
        {
            case Comportamiento.Enemigo1:
                MirarAlJugador();
                break;
            case Comportamiento.Enemigo2:
                Perseguir();
                break;
            default:
                MirarAlJugador();
                break;
        }
    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AnalizarComportamientoElegido();
    }
}
