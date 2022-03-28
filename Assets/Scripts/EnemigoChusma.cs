using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoChusma : MonoBehaviour
{
    private Quaternion rotacionQuaternion;
    public float velocidadRotacionEnemigo;
    public GameObject jugador;

    void MirarAlJugador()
    {
        rotacionQuaternion = Quaternion.LookRotation (jugador.transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Lerp(transform.rotation, rotacionQuaternion, velocidadRotacionEnemigo);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MirarAlJugador();
    }
}
