using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Relativo a Monito
    public float velocidad = 10.0f; // variable pueblica se puede acceder desde unity
    Rigidbody2D cuerpoMonito; // se crea el objeto de banano
    float coordX = 0.0f;
    Animator anime;
    bool verDerecha = true; // porque la silueta de mi personaje siemrpe esta hacia la derecha
    // Relativo al Arma
    public GameObject poder;
    public Transform arma;
    public float velocidadBala = 30.0f;
    public AudioSource musica;
    public AudioSource musicb;


    // Start is called before the first frame update
    void Start()
    {
        cuerpoMonito = GetComponent<Rigidbody2D>(); // digo que el cuerpo del banano es igual al objeto que tiene este script
        anime = GetComponent<Animator>(); // digo que la animacion es igual al componente de animacion que esta asociado a banano
    }

    // Update is called once per frame
    void Update()
    {
        coordX = Input.GetAxis("Horizontal"); // obtengo el valor de la coordenada a la cual se esta dirigiendo banano
        if (coordX != 0) // si se esta moviendo
        {
            anime.SetBool("Caminar", true); // activo la animacion de correr
            if (coordX > 0 && !verDerecha || coordX < 0 && verDerecha) // si se mueve en una orientacion diferente invierto la orientacion de banano
            {
                GirarPersonaje(); // invierto orientacion de banano
            }

        }
        else
        {
            anime.SetBool("Caminar", false); // si no se detecta cambios en la coordenada indico que no se esta moviendo
        }

        if (Input.GetButtonDown("Fire1")) // si se preciona la entrada pre establecida como fire 1 se activa la animacion de disparar
        {
            print("disparas");
            anime.SetTrigger("disparar");
        }
    }
    private void GirarPersonaje()
    {
        verDerecha = !verDerecha;
        Vector3 giro = transform.localScale; // permite girar la imegen crendo un especjo del personaje mateniendo su escla u posicion
        giro.x *= -1;
        transform.localScale = giro;

    }
    private void FixedUpdate() // este metodo se utiliza para trabajar con fisicas
    {
        cuerpoMonito.velocity = new Vector3(coordX * velocidad * Time.deltaTime, 0, 0); // hacemos que se mueva el banano


    }
    public void disparar()
    {
        // Este codigo es para investir la rotacion de una imegen "poder"
        Vector2 direccion = verDerecha ? Vector2.right : Vector2.left; // si esta mirando igual que mi variabke entonces 
        float angulo = verDerecha ? 0f : 180f; // rota la bala hacia donde esta apuntando el personaje
        GameObject clon = Instantiate(poder, arma.position, Quaternion.Euler(0, 0, angulo));
        // GameObject clon = Instantiate(poder, arma.position, arma.rotation);
        Rigidbody2D cl = clon.GetComponent<Rigidbody2D>(); // se optienen todos los componentes del rigi bodi
        // cl.velocity = (arma.right * velocidad);
        cl.velocity = direccion * velocidadBala;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "enemigo")
        {
            print("suena musiquita");
            musica.Play();
            Destroy(gameObject);



        }
        if (collision.gameObject.tag == "amigo")
        {
            musicb.Play();
            print("suena musiquita de hongo verde");
        }
    }
}
