using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
//using UnityEngine.Windows;

public class mostrarDatosEscenaAnterior : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public TextMeshProUGUI player;
    //public TextMeshProUGUI texto2;
    //public TextMeshProUGUI mensaje;
    //public TMP_InputField nombre;
    // variables comunes
    public static int contEnemigos = 0;
    //static StreamWriter archivo = null;
    static StreamReader leer = null;
    public static string dato = "0";
    public static string juagador = "Sin nombre";   
    //public GameObject panel;
    //public GameObject panelNivel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Enemigos Eliminados: " + contEnemigos.ToString();
    }
    private void Awake()
    {
        //int c = 0;

        if (File.Exists("Puntaje.txt"))
        {
            leer = File.OpenText("Puntaje.txt");
            //print("Leemos el archivo");
            print(dato);
            dato = leer.ReadLine();
            print("Extraemos dato");
            print(dato);
            leer.Close();
            string[] d = dato.Split(" , ");

            contEnemigos = int.Parse(d[0]);
             juagador = d[1];
        }
        player.text = juagador;
    }
}
