using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float velocidad = 10.0f; // variable pueblica se puede acceder desde unity
    Rigidbody2D cuerpoBanana; // se crea el objeto de banano
    float coordX = 0.0f;
    float coordY = 0.0f;
    public bool tocar_piso = false; // por defecto comieza elebado , sin tocar el piso
    public float fuerza = 10.0f; // fuerza del brico
    Animator anime;
    bool verDerecha = true; // porque la silueta de mi personaje siemrpe esta hacia la derecha

    public GameObject poder;
    public Transform arma;
    public float velocidadBala = 30.0f;
    bool mirarHacia = true; // indica que el persoaje esta mirndo hacia la derecha
    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource musica5;
    //public AudioSource music4;

    void Start()
    {
        cuerpoBanana = GetComponent<Rigidbody2D>(); // digo que el cuerpo del banano es igual al objeto que tiene este script
        anime = GetComponent<Animator>(); // digo que la animacion es igual al componente de animacion que esta asociado a banano
    }
    // Update is called once per frame
    void Update()
    {

        coordX = Input.GetAxis("Horizontal"); // obtengo el valor de la coordenada a la cual se esta dirigiendo banano
        if (coordX != 0) // si se esta moviendo
        {
            anime.SetBool("correr", true); // activo la animacion de correr
            if (coordX > 0 && !verDerecha || coordX < 0 && verDerecha) // si se mueve en una orientacion diferente invierto la orientacion de banano
            {
                GirarPersonaje(); // invierto orientacion de banano
            }

        }
        else
        {
            anime.SetBool("correr", false); // si no se detecta cambios en la coordenada indico que no se esta moviendo
        }

        if (Input.GetButtonDown("Fire1")) // si se preciona la entrada pre establecida como fire 1 se activa la animacion de disparar
        {
            print("disparas");
            anime.SetTrigger("disparar");
        }
        // coordY = Input.GetAxis("Vertical");

        //Vector3 mover = new Vector3(coordX, coordY, 0);
        //transform.position += mover * velocidad * Time.deltaTime;





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
        cuerpoBanana.velocity = new Vector3(coordX * velocidad * Time.deltaTime, 0, 0); // hacemos que se mueva el banano

        if (cuerpoBanana.velocity.x < 0)
        {

        }
        if (Input.GetKey(KeyCode.Space) && tocar_piso == true)
        {
            print("saltando");
            cuerpoBanana.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse); // hago que banano salte
            tocar_piso = false;
            anime.SetBool("brincar", true); // activo animacion de saltar
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) // esta funcion se activa cada que mi objeto tenga una colicion por box colaider
    {
        if (collision.gameObject.CompareTag("barrera")) // si coliciona con el piso
        {
            print("pisando el piso");
            tocar_piso = true; // esta tocando el piso
            anime.SetBool("brincar", false); // desactivamos la animacion de saltar
        }
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

        if (collision.gameObject.tag == "caballero")
        {
            print("suena musiquita");
            music2.Stop();
            music3.Stop();
            music1.Play();
            // Destroy(gameObject);
        }
        if (collision.gameObject.tag == "rey")
        {
            music2.Play();
            music1.Stop();
            music3.Stop();
            print("suena musiquita de rey");
            //  Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "reina")
        {
            music3.Play();
            music2.Stop();
            music1.Stop();
            print("suena musiquita de reina");
            // Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "enemigo")
        {
            print("suena musiquita");
            
            
            musica5.Play();
 
            transform.position += new Vector3(0, 0, 1);
        }


    }
}
