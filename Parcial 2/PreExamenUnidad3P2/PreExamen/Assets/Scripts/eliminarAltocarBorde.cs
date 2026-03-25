//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class eliminarAltocarBorde : MonoBehaviour
{
    public float velocidad = 50.0f;
    public float distancia = 30f;
    Vector2 posicion;
    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * velocidad * Time.deltaTime); // indica que se mueva hacia la izquierda "left" (-1,0,0)
        //transform.Translate(Vector3.down * velocidad * Time.deltaTime); // indica que se mueva hacia abajo "down" (0,-1,0)
        float inicio = Vector2.Distance(posicion, transform.position); // calucla la diatancia del objeto respecto a donde se instancio
        inicio = Mathf.Abs(inicio); // optiene el valor absoluto de un dato abs(-5) = 5
        if (inicio > distancia)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "limite")
        {
            Destroy(gameObject);
        }
    }
}
