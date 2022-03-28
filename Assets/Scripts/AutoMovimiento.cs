using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovimiento : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadRotacion;

    void Movimiento()
    {
        transform.position += transform.forward * Input.GetAxisRaw("Vertical") * velocidadMovimiento * Time.deltaTime;

        transform.Rotate(new Vector3 (0, 1, 0) * Input.GetAxisRaw("Horizontal") * velocidadRotacion * Time.deltaTime);

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
