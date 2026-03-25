using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class crarArchivoIniciacion : MonoBehaviour
{
    public TextMeshProUGUI mensaje;
    public TMP_InputField nombre;
   
    controladorArchivo archivo = new controladorArchivo();

    // Start is called before the first frame update

    public void SiguienteEscena()
    {
        try
        {
            string n = nombre.text;
            if (n.Length != 0)
            {
                string entrada = "0 , " + n;
                if (archivo.ModificarAarchivo("pajaro.txt", entrada))
                {
                    SceneManager.LoadScene("juego"); //loadScene("Nivel2");
                }
            }
            else
            {
                mensaje.text = "No tiene nombre";
            }
                
            
        }
        catch (Exception ex)
        {
            print(ex.Message);
        }
        
    }
}
