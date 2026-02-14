using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class ataque : MonoBehaviour
{
    public float distancia = 30.0f;
    Vector2 posicion;
    public GameObject explocion;
    //public AudioSource audioExplocion; 


    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position; // la posiscion de donde se creo la bala 
        //audioExplocion.Stop();  
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
    //public void disparar()
    //{
    //    // Este codigo es para investir la rotacion de una imegen "poder"
    //    Vector2 direccion = mirarHacia ? Vector2.right : Vector2.left; // si esta mirando igual que mi variabke entonces 
    //    //float angulo = mirarHacia ? 90f : 270f;
    //    // GameObject clon = Instantiate(poder,arma.position, Quaternion.Euler(0, 0, angulo));
    //    GameObject clon = Instantiate(poder, arma.position, arma.rotation);
    //    Rigidbody2D cl = clon.GetComponent<Rigidbody2D>(); // se optienen todos los componentes del rigi bodi
    //    cl.velocity = (arma.right * velocidad);
    //    cl.velocity = direccion * velocidad;
    //
    private void OnTriggerEnter2D(Collider2D collision) // colicion mediante triger
    {
        if (collision.gameObject.tag == "piso")
        {
            Destroy(gameObject); // destruigo el objeto de mi bala si toco el piso
        }
        if (collision.gameObject.tag == "enemigo")
        {
            
            //audioExplocion.Play();
            Destroy(gameObject); // destruigo el objeto de mi bala si le dio a un enemigo
            //GetComponent<Renderer>().enabled = false;
             
            Destroy(collision.gameObject); // destruigo el objeto del enemigo cuando le dio mi bala
            GameObject cloneExplocion = Instantiate(explocion, transform.position, transform.rotation); // inicializo la animacion de mi explocion
            Destroy(cloneExplocion,1.5f);  // destrigo el objeto de mi explocion  
            
            
        }
    }
}
