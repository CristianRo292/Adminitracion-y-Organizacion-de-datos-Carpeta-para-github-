//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public float velocidad = 10.0f; // variable pueblica se puede acceder desde unity
    Rigidbody2D cuerpoBanana; // se crea el objeto de banano
    float coordX = 0.0f;
    float coordY = 0.0f;
    public bool tocar_piso = false; // por defecto comieza elebado , sin tocar el piso
    public float fuerza = 10.0f; // fuerza del brico
    public AudioSource musicaFruta;
    public AudioSource musicaEnemigo;

    public float velocidadBala = 30.0f;
    

    void Start()
    {
        cuerpoBanana = GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    {

        coordX = Input.GetAxis("Horizontal");
        if (coordX < 0.0f) coordX = 0.0f;
        coordY = Input.GetAxis("Vertical");
    }
    //private void GirarPersonaje()
    //{
    //    verDerecha = !verDerecha;
    //    Vector3 giro = transform.localScale; // permite girar la imegen crendo un especjo del personaje mateniendo su escla u posicion
    //    giro.x *= -1;
    //    transform.localScale = giro;

    //}
    private void FixedUpdate() // este metodo se utiliza para trabajar con fisicas
    {
        //cuerpoBanana.velocity = new Vector3(coordX * velocidad * Time.deltaTime,0 , 0); // hacemos que se mueva el banano
        cuerpoBanana.velocity = new Vector2(coordX * velocidad, coordY * velocidad);
        //if (cuerpoBanana.velocity.x < 0)
        //{

        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fruta")
        {
            musicaFruta.Play();
            //print("eliminar");
            Destroy(collision.transform.root.gameObject);
            contadorDeEnemigos.EnemigosEliminados(); // madamos llamar a la funcion de otro scrip para aumtenar el contador
        }
        else if (collision.gameObject.tag == "enemigo")
        {
            musicaEnemigo.Play();
            print("colicion con enemigo");
            cuerpoBanana.transform.position = new Vector3(0, 0, -1);

        }
    }

}
