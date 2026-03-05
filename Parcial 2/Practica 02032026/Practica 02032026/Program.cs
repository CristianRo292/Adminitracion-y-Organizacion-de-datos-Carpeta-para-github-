// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Una empresa necesita un pequeño sistema en consola para registrar usuarios antes de permitirles acceder a su sistema interno.

//El programa deberá mostrar un menú y solicitar los siguientes datos:

//Nombre completo

//Edad

//Salario

//Correo electrónico

//Número telefónico

//Contraseña

//Cada dato deberá validarse con expresiones regulares.
class Program()
{
    static Validaciones val = new Validaciones();
    static void Main(string[] args)
    {
        int op = 0;
        do
        {
            op = Menu();
            Console.WriteLine("Estamos seleccionando la opcion");
            Console.WriteLine(op);
            switch (op)
            {
                
                case 1:
                Regresar:
                    GuardarDatos(RegistarDatos());
                    Console.WriteLine("Agregar Otro (S/N)");
                    string resp = Console.ReadLine();
                    if (resp == "S")
                    {
                        goto Regresar;
                    }
                    break;
                case 2:
                    Console.WriteLine("Mostrar");
                    Mostrar();
                    break;
                case 3:
                    Console.WriteLine("Salir");
                    break;
            }
        } while (op != 3);

    }
    static int Menu()
    {
        // int respuesta = 0;
        Console.WriteLine("Selecciona una opcion del menu");
        Console.WriteLine("1. Registrar Nuevo Usuario");
        Console.WriteLine("2. Mostrar ");
        //Console.WriteLine("2. Mostrar datos");
        Console.WriteLine("3. Salir");
        string res = Console.ReadLine();

        if (Regex.IsMatch(res, @"^[1-3]+$"))
        {
            return int.Parse(res);
        }
        return Menu(); 
        
    }
    static string RegistarDatos()
    {
        string datos = "";
        string nombre, edad, salario, correo, tel, contraseña;
        Console.WriteLine("Pedimos datos");
        while (true)
        {
            Console.WriteLine("Escribe el nombre: ");
            nombre = Console.ReadLine();
            if (val.ValidarString(nombre))
            {
                break;
            }

            Console.WriteLine("Error al introducir el nombre");
            
        }
        while (true)
        {

            Console.WriteLine("Escribe la edad");
            edad = Console.ReadLine();
            if ((val.ValidarEdad(edad)))
            {
                break;
            }
            Console.WriteLine("Error al introducir la edad");

        }
        while (true)
        {

            Console.WriteLine("Escribe el salario");
            salario = Console.ReadLine();
            if ((val.ValidarSalario(salario)))
            {
                break;
            }
            Console.WriteLine("Error al introducir el salario");

        }
        while (true)
        {

            Console.WriteLine("Escribe el Correro Electronico");
            correo = Console.ReadLine();
            if (val.ValidarCorreo(correo))
            {
                break;
            }
            Console.WriteLine("Error al introducir el correo");

        }
        while (true)
        {

            Console.WriteLine("Escribe el numero de Telefono");
            tel = Console.ReadLine();
            if (val.ValidarTelefono(tel))
            {
                tel = DarFormatoNumero(tel);
                break;
            }
            Console.WriteLine("Error al introducir el telefono");

        }
        while (true)
        {

            Console.WriteLine("Escribe la Contraseña");
            contraseña = Console.ReadLine();
            if ((val.ValidarContraseña(contraseña)))
            {
                break;
            }
            Console.WriteLine("Error al introducir el nombre");

        }

        string formato = " , ";
        datos = nombre + formato + edad + formato + salario + formato + correo + formato + tel + formato + contraseña;
        string[] d = datos.Split(" , ");
        Console.WriteLine("el nombre es:" + d[0]); // aqui la "+" si importa, la coma actua difrentes 
        Console.WriteLine("La edad es: " + d[1]);
        Console.WriteLine("El salario es: " + d[2]);
        Console.WriteLine("El correo es: " + d[3]);
        Console.WriteLine("El numero de telefono es: " + d[4]);
        Console.WriteLine("La contraseña es: " + d[5].Length);

       



        return datos;
    }

    static void GuardarDatos( string datos)
    {
        StreamWriter archivo = null;
        archivo = File.AppendText("datos.txt");
        archivo.WriteLine(datos);
        archivo.Close();
    }
    static void Mostrar()
    {
        Console.WriteLine("dentro de mostrar");
        if (!(File.Exists("datos.txt")))
        {
            Console.WriteLine("El archivo no existe");
            return;
        }
        StreamReader leerArchivo = null;
        leerArchivo = File.OpenText("datos.txt");
        string datos;
        do
        {
            datos = leerArchivo.ReadLine();
            if (datos != null)
            {
                string[] d = datos.Split(" , ");
                Console.WriteLine("el nombre es:" + d[0]); // aqui la "+" si importa, la coma actua difrentes 
                Console.WriteLine("La edad es: " + d[1]);
                Console.WriteLine("El salario es: " + d[2]);
                Console.WriteLine("El correo es: " + d[3]);
                Console.WriteLine("El numero de telefono es: " + d[4]);
                Console.WriteLine("La longitud de contraseña es: " + d[5].Length);
                
            }

        }
        while (datos != null); // se repite hasta que el archivo regrese un valor null
        leerArchivo.Close();
    }

    static string DarFormatoNumero(string tel)
    {
        string datosForm = "(" + tel.Substring(0, 3) + ")" + " " + tel.Substring(3, 3) + "-" + tel.Substring(5,4); // el metodo subestrin te pide elvalor de donde empieza y la cantidad de carcateres que quieres extrar
        return datosForm;
    }

}
