using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Validaciones()
{ 
    public bool ValidarString(string nombre)
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

        //// mi version 
        //foreach (char a in nombre)
        //{
        //    if (!((a >= 97 && a <= 122) || (a >= 65 && a <= 90) || a == 32))
        //    {
        //        Console.WriteLine("Nombre erronio");
        //        return false;
        //    }
        //}
        //if (c == nombre.Length)
        //{
        //    Console.WriteLine("nombre Correcto");
        //    return true;
        //}
        return Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$");
        //Console.WriteLine("Nombre Correcto");
        //return true;
    }

    public bool ValidarEdad(string edad)
    {
        //bool respuesta = (Regex.IsMatch(edad, @"^[0-9]+$")); // revisa que eel dato ingresado este ciempre dentro de este rango
        //if (respuesta)
        //{
        //    int e = int.Parse(edad);
        //    if (e >= 18 && e <= 99)
        //    {
        //        return true;
        //    }
            
        //}
        return Regex.IsMatch(edad, @"^(1[8-9]|[2-9][0-9])$");
    }

    public bool ValidarSalario(string salario)
    {
        //try 
        //{ 
        //    float sal = float.Parse(salario);
        //    salario = salario + ".0";
        //    string[] d = salario.Split(".");
        //    if (d[1].Length <= 2)
        //    {
        //        return true;
        //    }
        //    return false;
        //} 
        //catch 
        //{
        //    return false;

        //}
        return Regex.IsMatch(salario, @"^\d+(\.\d{1,2})?$");
        
    }
    public bool ValidarCorreo(string correro)
    {
        //try
        //{
        //    string[] subCorreo = correro.Split("@");
        //    string[] dominio = subCorreo[1].Split(".");
        //    if (dominio[0].Length > 1 && dominio[1].Length > 1 && subCorreo[0].Length > 1)
        //    {
        //        return true;
        //    }
        //}
        //catch
        //{

        //}
        //return false;
        return Regex.IsMatch(correro, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
    }
    public bool ValidarTelefono(string telefono)
    {
        //try 
        //{
        //    long tel = long.Parse(telefono);
        //    Console.WriteLine(tel);
        //    Console.WriteLine(telefono.Length);
        //    if (telefono.Length == 10)
        //    {
        //        return true;
        //    }
        //}
        //catch 
        //{
        //    return false;
        //}
        return Regex.IsMatch(telefono, @"^\d{10}$");
    }
    public bool ValidarContraseña(string contrase)
    {
        //if (contrase.Length >= 8)
        //{
        //    bool contMay = false;
        //    bool contMin = false;
        //    bool conyNum = false;

        //    foreach (char a in contrase)
        //    {
        //        if (a == 32)
        //        {
        //            return false;
        //        }
        //        if (a >= 'a' && a <= 'z')
        //        {
        //            contMin = true;
        //        }
        //        else if (a >= 'A' && a <= 'Z')
        //        {
        //            contMay = true;
        //        }
        //    }
        //    if (contMay && contMin)
        //    {
        //        return true;
        //    }
        //}
        
        return Regex.IsMatch(contrase, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{8,}$");
        // explicacion :
        //@ se usa para permitir que la exprecion se usen diagonales invertidas
        // ^ indica el inicio de la cadena
        //?= se usa para indicar que esta buecando si existe algo en lacadena
        // . indica todo o cualquier cosa
        // * indica muchos (cero o mas)
        // [a-z] rango de valores, en este caso letras
        // \d busca digitos, OJO si fuera solo d buscaria la letra d, por eso de usa la diagonal para indicar que no la trate como una letra
        // \S Indica que no debe tener espacios, OJO si tubiera la letra s minuscula indicaria que si puede haver espacios
        // {8, } se usa para indica la extencion total que debe tener nuestra cadena, en este caso minimo 8, 
        // $ indica el final de la cadena, en este caso como se esta usando el ^ y el $ en la misma exprecion estamos indicandoque la cadena debe tener esta forma exacta
    }
    //static bool ValidarInt(string str)
    //{

    //}
}
