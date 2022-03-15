using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primer : MonoBehaviour
{
    public Vector3 escalaCubo;          //Defino variables
    public Vector3 movimientoCubo;
    public GameObject elCubo;
    
    // Start is called before the first frame update
    void Start()
    {
      movimientoCubo = new Vector3 (0f, 0f, 0.01f);       //Le inicializo el valor a ambas variables
      elCubo.transform.localScale = escalaCubo;   //Al apretar start, cambia la escala del cubo por el valor de "Escala Cubo"
    }

    // Update is called once per frame
    void Update()
    {
      elCubo.transform.position += movimientoCubo;  //Le digo que le sume 1 sobre el eje Z en cada frame para que se mueva constantemente a esa velocidad.
    }
}
