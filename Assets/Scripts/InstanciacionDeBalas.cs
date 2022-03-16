using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciacionDeBalas : MonoBehaviour
{
    public GameObject laBala;
    public float speed;
    public Vector3 direction;
    public int damage;
    public Transform canon;
       
    void InstanciarBala()
    {
        Instantiate(laBala, canon.position, Quaternion.identity);

    }

    void Disparo()
    {
        direction = laBala.transform.position;
        direction.z += speed *Time.deltaTime;
        direction.x += speed*Time.deltaTime;
        direction.y += speed*Time.deltaTime;
        laBala.transform.position = direction;
    }
    
    void Start()
    {
        InstanciarBala();
    }

    
    void Update()
    {
        Disparo();
    }
}
