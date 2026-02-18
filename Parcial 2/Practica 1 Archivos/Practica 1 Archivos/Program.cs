using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "datos.txt";
            string nombre;
            int edad;
            double estatura;
            StreamWriter archivo = null;
            StreamReader leerArchivo = null;
            if (File.Exists(nombreArchivo))
            {
                // leemos el archivo
                leerArchivo = File.OpenText(nombreArchivo);
                string datos;
                do
                {
                    datos = leerArchivo.ReadLine();
                    string[] d = datos.Split(" , ");
                    Console.WriteLine("el nombre es:" + d[0]); // aqui la "+" si importa, la coma actua difrentes 
                }
                while (datos != null); // se repite hasta que el archivo regrese un valor null
                leerArchivo.Close();
                return;
            }
           
            archivo = File.AppendText(nombreArchivo); // creamos el archivo con el nombre pre definido, esta abierto para escribir

            for (int i = 0; i < 6; i ++)
            {
                Console.WriteLine("Escribe el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Escribe la edad");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe la estatura");
                estatura = Convert.ToDouble(Console.ReadLine());

                // Escribimos los datos en el archivo
                archivo.WriteLine(nombre + " , " + edad + " , " + estatura);
            }
            
            archivo.Close(); // cerramos archivo
            

            

            



        }
    }
}
