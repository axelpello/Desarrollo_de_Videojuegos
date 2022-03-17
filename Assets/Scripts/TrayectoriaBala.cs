using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayectoriaBala : MonoBehaviour
{   
    public Vector3 direction;
    public float speed;
    public int damage;
    
    
     
    void MovimientoBala()
    {
        direction.z *= speed; 
        direction.x *= speed;
        direction.y *= speed;
        this.transform.position += direction;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      MovimientoBala();  
    }
}
