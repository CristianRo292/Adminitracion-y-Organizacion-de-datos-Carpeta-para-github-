//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    //public AudioSource musica;
    // Start is called before the first frame update
    public Transform personaje; // objeto al cual va a seguir
    //Vector3 posicion;
    Vector3 fueraCamara;
    float coorY;
    public float minCordX;
    public float maxCordX;
    public float minCordY;
    public float maxCordY;
    public float velocidadCamara = 10.0f;
    void Start()
    {
        //posicion = transform.position - personaje.position; // busca la posicion del personaje, y resta la posicion del personaje para saber donde esta
        //musica.Play();
        fueraCamara = transform.position - personaje.position;
        //coorY = transform.position.y;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Vector3 nuevaPosicion = personaje.position + posicion;
    //    transform.position = Vector3.Lerp(transform.position, nuevaPosicion,velocidadCamara * Time.deltaTime); // movemos la camara a la posicion del personaje
    //}
    private void LateUpdate()
    {
        float objetivo = personaje.position.x + fueraCamara.x;
        objetivo = Mathf.Clamp(objetivo, minCordX, maxCordX);
        float objetivoY = personaje.position.y + fueraCamara.y;
        objetivoY = Mathf.Clamp(objetivoY, minCordY, maxCordY);
        Vector3 objetivoX = new Vector3(objetivo, objetivoY, transform.position.z); // coordenadas de mi objetivo
        transform.position = Vector3.Lerp(transform.position, objetivoX, velocidadCamara * Time.deltaTime); // mandamos a la camara a vijilar

    }
}
