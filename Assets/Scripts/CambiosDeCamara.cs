using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiosDeCamara : MonoBehaviour
{
    public GameObject camaraDeAtras;
    public GameObject camaraDeCostado;
    private int contador;
    
    void SumarContador()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            contador++;
        }
    }

    void CambiarCamara()
    {
        if (contador == 1)
        {
           camaraDeAtras.SetActive(true);
           camaraDeCostado.SetActive(false);
        }
        else if (contador ==2)
        {
            camaraDeAtras.SetActive(false);
            camaraDeCostado.SetActive(true);
        }
        else {contador = 1;}
    }
    
    void Start()
    {
       contador=1; 
    }

    // Update is called once per frame
    void Update()
    {
        SumarContador();
        CambiarCamara();
    }
}
