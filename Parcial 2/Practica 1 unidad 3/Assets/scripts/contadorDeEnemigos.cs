using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;

public class contadorDeEnemigos : MonoBehaviour
{
    // variables de inferfas grafica
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;
    public TextMeshProUGUI mensaje;
    public TMP_InputField nombre;
    // variables comunes
    public static int contEnemigos = 0;
    static StreamWriter archivo = null;
    static StreamReader leer = null;
    public static string dato = "0";
    public GameObject panel;
     // bool est = false;


    // Start is called before the first frame update
    public static void EnemigosEliminados()
    {

        contEnemigos++;
        //CrearAchivo();
        
    }
   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            print("Guardar Datos");
            //panel.SetActive(!est);
            panel.SetActive(!panel.activeSelf); // negamos el estado original de panel
            Time.timeScale = 0f; // pausa el juego
            print("pumm");
            texto2.text = "Datos Guardados: " + contEnemigos.ToString();
            if (panel.activeSelf)
            {
                mensaje.text = "Mensaje..."; // linea experimental
            }
        }
        else if (panel.activeSelf == false)
        {
            Time.timeScale = 1f; // reaunida el juego
        }
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
            //print("Leemos el archivo");
            print(dato);
            dato = leer.ReadLine();
            print("Extraemos dato");
            print(dato);
            leer.Close();
            string[] d = dato.Split(" , ");
      
            contEnemigos = int.Parse(d[0]);
            nombre.text = d[1];
        }
    }

    public  void CrearAchivo()
    {
        string n = nombre.text;
        if (n.Length == 0)
        {
            mensaje.text = "No tiene nombre";
            return;
        }
        mensaje.text = "Guardado";
        if (File.Exists("Puntaje.txt"))
        {
            File.Delete("Puntaje.txt");
        }
        archivo = File.AppendText("Puntaje.txt");
        archivo.WriteLine(contEnemigos + " , " + nombre.text);
        archivo.Close();
    }
}
