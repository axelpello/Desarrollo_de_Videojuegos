using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDelCubo : MonoBehaviour
{
    public float velocidad;

    void Movimiento()
    {
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");
        float movimientoVertical = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(movimientoHorizontal, 0, movimientoVertical) * velocidad * Time.deltaTime;
    }
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }
}
