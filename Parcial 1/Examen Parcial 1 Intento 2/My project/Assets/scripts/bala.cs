using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float distancia = 30.0f;
    Vector2 posicion;
    // public GameObject explocion;
    // public AudioSource audioExplocion;


    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position; // la posiscion de donde se creo la bala 
        // audioExplocion.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        float inicio = Vector2.Distance(posicion, transform.position);
        inicio = Mathf.Abs(inicio);
        if (inicio > distancia)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "barrera")
        {
            Destroy(gameObject); // destruigo el objeto de mi bala si toco el piso
        }
        if (collision.gameObject.tag == "enemigo")
        {

            
            Destroy(gameObject); // destruigo el objeto de mi bala si le dio a un enemigo

            Destroy(collision.gameObject); // destruigo el objeto del enemigo cuando le dio mi bala
            print("colision de bala");


        }
    }
}
