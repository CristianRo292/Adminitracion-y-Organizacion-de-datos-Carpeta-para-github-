using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class contadorDeEnemigos : MonoBehaviour
{
    public static int contEnemigos = 0;
    static StreamWriter archivo = null;
    static StreamReader leer = null;
    public static string dato = "0";
    // Start is called before the first frame update
    public static void EnemigosEliminados()
    {

        contEnemigos++;
        //CrearAchivo();
        
    }
    public TextMeshProUGUI texto;

    private void Update()
    {
        texto.text = "Enemigos Eliminados: " + contEnemigos.ToString();

    }
    private void Start()
    {
        
        
    }
    private void Awake()
    {
        //int c = 0;
        
        if (File.Exists("Puntaje.txt"))
        {
            leer = File.OpenText("Puntaje.txt");
            //do
            //{
                //if (leer.ReadLine() != null)
                //{
                    print(dato);
                    dato = leer.ReadLine();
                //}
            //}
            //while (leer != null);
            leer.Close();
            contEnemigos = int.Parse(dato);
        }
    }

    public static void CrearAchivo()
    {
        if (File.Exists("Puntaje.txt"))
        {
            File.Delete("Puntaje.txt");
        }
        archivo = File.AppendText("Puntaje.txt");
        archivo.WriteLine(contEnemigos);
        archivo.Close();
    }
}
