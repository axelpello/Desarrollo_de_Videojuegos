using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se deberá hacer un script que contenga las variables: vida, velocidad, 
//dirección. Además, deberá contener un método que controle el movimiento, 
//un método que cure al jugador (suba el valor de la vida) y un método que dañe al jugador (baje el valor de la vida). 
//No es necesario que estén implementados (es decir, que hagan algo al darle play) pero si es necesario que se encuentren bien armados
// Pueden valerse de los métodos Start y Update para probar si sus métodos funcionan

public class ReEntregaScriptDos : MonoBehaviour
{
    public int vida;    //Vida del jugador que cuando comienza el juego siempre está en 100.
    public int subirHp; //La cantidad de puntos que querés darle a la vida del jugador.
    public int dañarJugador; //La cantidad de daño que querés hacerle al jugador.
    public float velocidad; //Altera la velocidad a la que se desplaza el jugador. Con números negativos, retrocede.
    Vector3 direccion;
    public GameObject elCubo;

    int AumentaLaVida()
    {
        vida += subirHp; 
        return vida;
    }

    int ReduceLaVida()
    {
        vida -= dañarJugador; //Este metodo funciona poniendole numeros positivos ya que se está RESTANDO. Si se ponen numeros negativos el método va a aumentar la vida del jugador.
        return vida;       //Podría entenderse como "Cuanto daño querés hacerle al jugador?". Por eso nombré así a la variable pensé que quizás era más comprensible.
    }
    
    void MoverEnElEjeZ() 
    {   
        direccion = elCubo.transform.position;      
        direccion += new Vector3(0f, 0f, velocidad); 
        elCubo.transform.position = direccion;         
    }
    


    void Start()
    {
        vida = 100; //No importa lo que esté por inspector. La vida del jugador siempre empieza en 100. 
        AumentaLaVida();       //El aumento o decremento de la vida se hace solo al empezar para que no esté sumandole constantemente puntos de vida al 
        ReduceLaVida();    //jugador. Como una poción de vida o un golpe.
    }


    void Update()
    {

        if (vida < 0)
            {
                Debug.Log ("El jugador ha muerto."); //Esto chequea en cada frame la vida del jugador y en caso de que ésta sea menor a 0, indica que el jugador está muerto.
            }
        MoverEnElEjeZ();
    }
}
