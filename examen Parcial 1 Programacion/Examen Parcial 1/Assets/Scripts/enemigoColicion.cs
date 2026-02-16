using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoColicion : MonoBehaviour
{
    public AudioSource musica;
    public AudioSource musicb;
    // Start is called before the first frame update
    void Start()
    {
        musica.Stop();
        musica.Stop();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.tag == "bala")
        {

            musica.Play();
            Destroy(gameObject);



        }
        if (collision.gameObject.tag == "player")
        {
            musicb.Play();
        }
    }
}
