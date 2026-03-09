using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creadorEnemigos : MonoBehaviour
{
    // creador enemigos derechos
    public GameObject macabron;
    public float tiempoParaGenerar = 3.0f;
    public Transform[] posicionD;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Generar()
    {
        while (true)
        {
            Cenemigos();
            yield return new WaitForSeconds(tiempoParaGenerar);
        }
    }

    void Cenemigos()
    {
        if (macabron == null || posicionD.Length == 0)
        {
            return;
        }
        Transform punto = posicionD[Random.Range(0, posicionD.Length)];
        Instantiate(macabron, punto.position, punto.rotation);
    }
}