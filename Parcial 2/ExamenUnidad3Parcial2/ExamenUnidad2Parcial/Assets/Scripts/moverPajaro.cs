using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class moverPajaro : MonoBehaviour
{
    public float velocidad = 10.0f; // variable pueblica se puede acceder desde unity
    Rigidbody2D cuerpoBanana; // se crea el objeto de banano
    float coordX = 0.0f;
    //float coordY = 0.0f;
    public bool tocar_piso = false; // por defecto comieza elebado , sin tocar el piso
    public float fuerza = 10.0f; // fuerza del brico
    public AudioSource musicaFruta;


    public float velocidadBala = 30.0f;
    //bool mirarHacia = true; // indica que el persoaje esta mirndo hacia la derecha
    controladorArchivo archivo = new controladorArchivo();
    public TextMeshProUGUI txt_Nombre;
    public TextMeshProUGUI txt_Puntaje;
    public GameObject panelNivel;
    public GameObject panelPrincipal;


    void Start()
    {
        cuerpoBanana = GetComponent<Rigidbody2D>(); // digo que el cuerpo del banano es igual al objeto que tiene este script
        
    }
    // Update is called once per frame
    void Update()
    {

        coordX = Input.GetAxis("Horizontal"); // obtengo el valor de la coordenada a la cual se esta dirigiendo banano
        if (coordX < 0.0f) coordX = 0.0f;






    }

    private void FixedUpdate() // este metodo se utiliza para trabajar con fisicas
    {
        //cuerpoBanana.velocity = new Vector3(coordX * velocidad * Time.deltaTime,0 , 0); // hacemos que se mueva el banano
        cuerpoBanana.velocity = new Vector2(coordX * velocidad, cuerpoBanana.velocity.y);
        
        if (Input.GetKey(KeyCode.Space))
        {
            
            cuerpoBanana.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse); // hago que banano salte
            

        }
        if (cuerpoBanana.velocity.y < 0) // si esta elevado eb y, entonces 
        {
            cuerpoBanana.gravityScale = 10;
        }
        else
        {
            cuerpoBanana.gravityScale = 8;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision) // esta funcion se activa cada que mi objeto tenga una colicion por box colaider
    {

        if (collision.gameObject.tag == "manzana")
        {
            musicaFruta.Play();
            print("eliminar");
            Destroy(collision.gameObject);
            mostrarDatosEscenaAnterior.EnemigosEliminados(); // madamos llamar a la funcion de otro scrip para aumtenar el contador
        }
        else if (collision.gameObject.tag == "bandera")
        {
           
            panelPrincipal.SetActive(false);
            string datosT = mostrarDatosEscenaAnterior.RetornarDatos();
            string[] datos = datosT.Split(" , ");
            txt_Nombre.text = "Puntaje optenido por: " + datos[1].ToString();
            txt_Puntaje.text = datos[0].ToString();
            panelNivel.SetActive(true);
            archivo.ModificarAarchivo(parametro:datosT);
            Time.timeScale = 0f;
            
        }
    }
}
 
