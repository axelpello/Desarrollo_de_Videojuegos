using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosTemporizados : MonoBehaviour
{
    public GameObject laBala;
    public Transform elCanon;
    public float empezarDesde;
    public float tiempo;
    public float destruirEn;
    public float destruccion;
    private GameObject balaInstanciada;
       
    void ReiniciarTiempo()
    {
        tiempo = empezarDesde;
    }    
    
    void Disparo()
    {
        balaInstanciada = Instantiate(laBala, elCanon.position, Quaternion.identity); //GUARDO LA INSTANCIACION DEL PREFAB BALA EN UNA VARIABLE PARA DESTRUIR LA INSTANCIA 
                                                                                            //MÁS TARDE Y NO EL PREFAB EN SÍ.
    }
    
    void DispararATiempo()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {   
            Disparo();
            destruccion = destruirEn; //INICIO TIEMPO DE DESTRUCCION
            ReiniciarTiempo();
        }
    }

    void DestruirBala()
    {
        if (destruccion <= 0)
        {
            Destroy(balaInstanciada); //BORRO LA INSTANCIA DE BALA.
        }
        else
            {destruccion -= Time.deltaTime;}
    }

    void DuplicarEscala()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            laBala.transform.localScale *= 2f; //TODAS LAS BALAS DUPLICAN SU VALOR.
            //balaInstanciada.transform.localScale *=2f        ←//SOLO LA BALA INSTANCIADA DUPLICA SU VALOR.
        }
    }

    void Start()
    {
        ReiniciarTiempo();
    }

    
    void Update()
    {
        DispararATiempo();
        DestruirBala(); //ES IMPORTANTE QUE LA BALA SE DESTRUYA EN MENOS TIEMPO DE LO QUE SE CREA PORQUE CADA VEZ QUE SE DISPARA UNA BALA SE REINICIA EL TIMER DE DESTRUCCION.
        DuplicarEscala();
    }
}
