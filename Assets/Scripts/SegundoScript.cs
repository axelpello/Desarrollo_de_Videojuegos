using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se deberá hacer un script que contenga las variables: vida, velocidad, 
//dirección. Además, deberá contener un método que controle el movimiento, 
//un método que cure al jugador (suba el valor de la vida) y un método que dañe al jugador (baje el valor de la vida). 
//No es necesario que estén implementados (es decir, que hagan algo al darle play) pero si es necesario que se encuentren bien armados
// Pueden valerse de los métodos Start y Update para probar si sus métodos funcionan

public class SegundoScript : MonoBehaviour
{
    public float vida;
    float velocidad;
    bool VidaMax;
    Vector3 direccion;
    public GameObject elCubo;

    float AumentaLaVida()
    {
        vida += 1f;
        return vida;
    }

    float ReduceLaVida()
    {
        vida -= 1f;
        return vida;
    }
    
    void MoverAdelanteEnElEjeZ() //Metodo para mover adelante al cubo.
    {   
        direccion = elCubo.transform.position;      //Guardo el valor de la posicion del cubo en una variable direccion.
        direccion += new Vector3(0f, 0f, velocidad); //Le sumo el 0.001F que quiero que avance.
        elCubo.transform.position = direccion;         //Le asigno el valor de direccion a la posicion del cubo, actualizandola.
    }

    void MoverAtrasEnElEjeZ() //Metodo para hacer retroceder al cubo.
    {   
        direccion = elCubo.transform.position;      
        direccion -= new Vector3(0f, 0f, velocidad); 
        elCubo.transform.position = direccion;         
    }
    


    void Start()
    {
        vida = 100f; //Inicializo la vida en 100 
        VidaMax = false;
        velocidad = 0.001f; //Inicializo la velocidad a la que va a ir el cubo.
    }


    void Update()
    {
        {
            AumentaLaVida();
            if (vida == 2000f)
            {
                VidaMax = true;         //Todo este barullo de código lo que hace es subir la vida a 2000 e inmediatamente bajarla a 0.
                while (vida > -1f)     //Lo puse para probarlo y lo dejé por si les interesa ver qué hace nomás.
                {                       
                    ReduceLaVida();         
                }
            }

        }

        if (vida < 0)
            {
                Debug.Log ("El jugador ha muerto."); //Cuando la vida llega a 0 imprime en consola. Esto indica la cantidad de veces que subió la vida al máximo y bajó al mínimo.
            }
        MoverAdelanteEnElEjeZ(); //Mueve el cubo a la velocidad de 0.001f por frame PARA ADELANTE.
         //MoverAtrasEnElEjeZ(); //Si quieren ver como funciona el mover atras pueden descomentarlo.
    }
}
