using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eliminarEnemigos : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource enemigoMuerte;
    void Start()
    {
        enemigoMuerte.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            enemigoMuerte.Play();
            print("eliminar");
            Destroy(collision.transform.root.gameObject);
            contadorDeEnemigos.EnemigosEliminados(); // madamos llamar a la funcion de otro scrip para aumtenar el contador
        }
    }
}
