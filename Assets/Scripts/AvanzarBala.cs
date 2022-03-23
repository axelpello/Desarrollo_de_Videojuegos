using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvanzarBala : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
      this.transform.position += new Vector3 (0f, 0f, 000.1f);
    }
}
