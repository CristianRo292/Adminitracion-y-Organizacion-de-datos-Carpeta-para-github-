using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemigoMover : MonoBehaviour
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
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        float inicio = Vector2.Distance(posicion, transform.position);
        inicio = Mathf.Abs(inicio);
        if (inicio > distancia)
        {
            Destroy(gameObject);
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "enemigo")
    //    {
    //        print("eliminar");
    //    }
    //}
}
