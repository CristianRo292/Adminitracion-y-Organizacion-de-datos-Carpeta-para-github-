//using System.Collections;
//using System.Collections.Generic;
using System;
using System.IO;
using TMPro;
//using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
//using UnityEngine.Windows;

public class mostrarDatosEscenaAnterior : MonoBehaviour
{
    public TextMeshProUGUI txt_P1_nombre;
    public TextMeshProUGUI txt_P1_puntaje;
    
    public GameObject panelNivel;

    public static int contEnemigos = 0;
    
    public static string nombre_jugador = "Sin nombre";   
    controladorArchivo archivo = new controladorArchivo();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public static void EnemigosEliminados()
    {

        contEnemigos++;
        

    }
    public  static string RetornarDatos()
    {
        string datos = contEnemigos + " , " + nombre_jugador;
        return datos;
    }
    


    // Update is called once per frame
    void Update()
    {
      
        txt_P1_puntaje.text = contEnemigos.ToString();
        txt_P1_nombre.text = nombre_jugador;
    }
    private void Awake()
    {
        try
        {
            string[] datos = archivo.ExtrarDatos().Split(" , ");
            nombre_jugador = datos[1];
            contEnemigos = int.Parse(datos[0]);
        }
        catch (Exception ex)
        {
            print(ex.Message);
            
        }


    }
}
