//using System.Collections;
//using System.Collections.Generic;
using System.IO;
using TMPro;
//using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class contadorDeEnemigos : MonoBehaviour
{
    // variables de inferfas grafica
    public TextMeshProUGUI Texto1Pan1;
    //public TextMeshProUGUI texto2;
    //public TextMeshProUGUI mensaje;
    public TMP_InputField nombre;
    public TextMeshProUGUI jugador;
    public TextMeshProUGUI puntosP2;
    string player = "Desconocido";
    // variables comunes
    public static int contEnemigos = 0;
    static StreamWriter archivo = null;
    static StreamReader leer = null;
    public static string dato = "0";
    // declaras los panles que vas a abrir
    //public GameObject panel;
    public GameObject panelNivel;
   
     // bool est = false;


    // Start is called before the first frame update
    public static void EnemigosEliminados()
    {

        contEnemigos++;
        //CrearAchivo();
        
    }
   

    private void Update()
    {
       
        Texto1Pan1.text = "Puntaje: " + contEnemigos.ToString();
        if (contEnemigos >= 10)
        {
            Time.timeScale = 0;
            panelNivel.SetActive(true);
            puntosP2.text = "Puntaje: " + contEnemigos.ToString();
        }
        jugador.text = player;
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
            player = d[1];
        }
    }

    public  void CrearAchivo()
    {
        string n = nombre.text;
        if (n.Length == 0)
        {
            //mensaje.text = "No tiene nombre";
            return;
        }
        //mensaje.text = "Guardado";
        if (File.Exists("Puntaje.txt"))
        {
            File.Delete("Puntaje.txt");
        }
        archivo = File.AppendText("Puntaje.txt");
        archivo.WriteLine(contEnemigos + " , " + nombre.text);
        archivo.Close();
        //mensaje.text = "";
        player = n.ToString();
    }

    public void SiguienteEscena()
    {
        GuardarAntesDeNivel();
        SceneManager.LoadScene("Nivel2"); //loadScene("Nivel2");
    }
    void GuardarAntesDeNivel()
    {
        if (File.Exists("Puntaje.txt"))
        {
            File.Delete("Puntaje.txt");
        }
        archivo = File.AppendText("Puntaje.txt");
        archivo.WriteLine(contEnemigos + " , " + nombre.text);
        archivo.Close();
    }
}
