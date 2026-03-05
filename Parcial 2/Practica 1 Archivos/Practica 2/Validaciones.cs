using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

 class Validaciones
    {
    public bool ValidarNombre(String nombre)
    {
        //byte[] ascii = Encoding.ASCII.GetBytes(nombre);
        ////int c = 0;
        //foreach(byte b in ascii)
        //{
        //    //if ((b >= 97 && b <= 122) || (b >= 65 && b <= 90) || b == 32)
        //    //{
        //    //    c++;
        //    //}
        //    if (!((b >= 97 && b <= 122) || (b >= 65 && b <= 90) || b == 32))
        //    {
        //        Console.WriteLine("Nombre erronio");
        //        return false;
        //    }

        //}
        foreach ( char a in nombre)
        {
            if (!((a >= 97 && a <= 122) || (a >= 65 && a <= 90) || a == 32))
            {
                Console.WriteLine("Nombre erronio");
                return false;
            }
        }
        //if (c == nombre.Length)
        //{
        //    Console.WriteLine("nombre Correcto");
        //    return true;
        //}

        Console.WriteLine("Nombre Correcto");
        return true;
    }

    public bool ValidarEdad(String edad)
    {
        bool respuesta = (Regex.IsMatch(edad, @"^[0-9]+$")); // revisa que eel dato ingresado este ciempre dentro de este rango
        return respuesta;
    }

    public bool ValidarSexo(String esta)
    {
        bool r = false;
        try
        {
            float estatura = float.Parse(esta);
            r = true;
        }
        catch (Exception e)
        {
            r = false;
        }
        return r;
    }
        
    }


