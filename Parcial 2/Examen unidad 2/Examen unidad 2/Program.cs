// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text.RegularExpressions;

class Program()
{
    public static void Main(string[] args)
    {
        int opcionSeleccionada = 0;
        do
        {
            opcionSeleccionada = Menu();
            switch (opcionSeleccionada) // los case no pueden existir sin un switch, en el se indica que es lo que se esta evaluando. 
            {
                case 1:
                    Console.WriteLine("Registrando Empleado...");
                    Registro();
                    break;
                case 2:
                    Console.WriteLine("Mostrando Empleados...");
                    Mostrar();
                    break;
            }

        }
        while (opcionSeleccionada != 3);
    }
    private static int Menu() // coloca static para que el metodo main pueda acceder a ellos
    {
        int respuesta = -1;
        Console.WriteLine("Selecciona una Opcion del menu");
        Console.WriteLine("1. Agregar Empleado");
        Console.WriteLine("2. Mostrar Empleados");
        Console.WriteLine("3. Salir");
        string respString = Console.ReadLine();
        if (Regex.IsMatch(respString, @"^[1-3]$"))
        {
            respuesta = int.Parse(respString);
            return respuesta;
        }
        Console.WriteLine(respString);
        return Menu();
    }
    private static void Registro()
    {
        string nombre = "", curp = "", edad = "", sueldo = "", correro = "", telefono = "", codigo = "", pasware = "" ;
        while (true)
        {
            Console.WriteLine("nombre");
            nombre = Console.ReadLine();
            if (Regex.IsMatch(nombre, @"^[A-Za-z ]{5,}$"))
            {
                break;
            }
            Console.WriteLine("nombre no valido");
        }
        while (true)
        {
            Console.WriteLine("Curp");
            curp = Console.ReadLine();
            if (Regex.IsMatch(curp, @"^[A-Za-z]{4}\d{6}[MH][A-Za-z]{5}.\d{1}$"))
            {
                break;
            }
            Console.WriteLine("curp No valido");
        }
        while (true)
        {
            Console.WriteLine("Edad");
            edad = Console.ReadLine();
            if (Regex.IsMatch(edad, @"^(1[8-9]|[2-5][0-9]|6[0-5])$")) // el simbolo * indica que puede haver de 0 a infinitos elemtno del caracter a la izquieda
            {
                break;
            }
            Console.WriteLine("edad no valido");
        }
        while (true)
        {
            Console.WriteLine("Sueldo Mensual");
            sueldo = Console.ReadLine();
            if (Regex.IsMatch(sueldo,@"^\d{1,}\.\d{0,}$" )) // el simbolo + indicaque debe hacer uno o mas elemento com los de el valor a la izquierda
            {
                break;
            }
            Console.WriteLine("Sueldo no valido");
        }
        while (true)
        {
            Console.WriteLine("Correo");
            correro = Console.ReadLine();
            if (Regex.IsMatch(correro, @"^[\w\-_\.]+@empresa\.com$"))
            {
                break;
            }
            Console.WriteLine("correo no Valido");
        }
        while (true)
        {
            Console.WriteLine("Numero de celular");
            telefono = Console.ReadLine();
            if (Regex.IsMatch(telefono, @"^(33|55|81)\d{8}$"))
            {
                break;
            }
            Console.WriteLine("Telefono no Valido");
        }
        while (true)
        {
            Console.WriteLine("Codigo");
            codigo = Console.ReadLine();
            if (Regex.IsMatch(codigo, @"^EMP-\d{4}$"))
            {
                break;
            }
            Console.WriteLine("codigo no Valido");
        }
        while (true)
        {
            Console.WriteLine("Contraseña");
            pasware = Console.ReadLine();
            if (Regex.IsMatch(pasware, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{10,}$"))
            {
                break;
            }
            Console.WriteLine("Contraseña no Valido");
        }
        StreamWriter archivo = null;
        archivo = File.AppendText("empleados.txt");
        string relleno = " | ";
        archivo.WriteLine(nombre + relleno + curp + relleno + edad + relleno + sueldo + relleno + correro + relleno+ telefono + relleno + codigo + relleno + pasware);
        archivo.Close();
    }

    private static void Mostrar()
    {

        if (!(File.Exists("empleados.txt")))
        {
            Console.WriteLine("El archivo no existe");
            return;
        }
        StreamReader archivoLec = null;
        archivoLec = File.OpenText("empleados.txt");
        string datos = null; // en esta variable se guardaran todos los datos por renglon
        do
        {
            datos = archivoLec.ReadLine(); // a datos metele lo que tiene el docuemntoen un renglon
            if (datos != null)
            {
                string[] d = datos.Split(" | ");
                Console.WriteLine("Nombre: " + d[0].ToUpper());
                Console.WriteLine("Curp: " + d[1]); // Substring(1, d[1].Length -2)   el .Replace, remplaza un caraccter por otro
                Console.WriteLine("Edad: " + d[2]);
                Console.WriteLine("Sueldo: $" + d[3]);
                Console.WriteLine("Correro: " + d[4].ToLower());
                Console.WriteLine("telefono: " + DarFormatoNumero(d[5]));
                Console.WriteLine("codigo: " + d[6]);
                Console.WriteLine("Longitud de contraseña: " + d[7].Length);

            }
        }
        while (datos != null);
        archivoLec.Close();
    }
    private static string DarFormatoNumero(string tel)
    {
        string datosForm = "(" + tel.Substring(0, 3) + ")" + " " + tel.Substring(3, 3) + "-" + tel.Substring(5, 4); // el metodo subestrin te pide elvalor de donde empieza y la cantidad de carcateres que quieres extrar
        return datosForm;
    }

}
