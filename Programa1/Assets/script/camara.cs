using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public AudioSource musica;
    //// Start is called before the first frame update
    //public Transform personaje; // optiene la corrdenada del personaje
    //Vector3 posicion;
    //public float velocidadCamara = 10.0f;
    void Start()
    {
        //posicion = transform.position - personaje.position; // busca la posicion del personaje, y resta la posicion del personaje para saber donde esta
        musica.Play();  
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 nuevaPosicion = personaje.position + posicion;
        //transform.position = Vector3.Lerp(transform.position, nuevaPosicion,velocidadCamara * Time.deltaTime); // movemos la camara a la posicion del personaje
    }
}
