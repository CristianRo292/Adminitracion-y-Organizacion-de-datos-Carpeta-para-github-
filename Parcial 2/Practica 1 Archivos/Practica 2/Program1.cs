// See https://aka.ms/new-console-template for more information
// Program1.WriteLine("Hello, World!");

class Program1
{
   static Validaciones val = new Validaciones();
    static void Main(string[] args)
    {
        // Console.WriteLine($"Versión de .NET: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");
        int op = 0;
        do
        {
            op = Menu();
            switch (op)
            {
                case 1:
                    Agregar();
                    break;
                case 2:
                    Console.WriteLine("Eliminar");
                    EliminarArchivo();
                    break;
                case 3: 
                    Console.WriteLine("Eliminar Dato");
                    ElimarElementoArchivo();
                    break;
                case 4:
                    Console.WriteLine("Mostrar Archivo");
                    Mostrar();
                    break;
                case 5:
                    Console.WriteLine("Salir");
                    break;

            }
        } while (op != 5);
        

    }

    static void ElimarElementoArchivo()
    {
        String nombre;
        Mostrar();
        Console.WriteLine("Escribe el nombre a eliminar");
        nombre = Console.ReadLine();
        // abrir para buscar
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
                if (nombre.Equals(d[0]))
                {
                    Console.WriteLine("Si lo encontro");
                }
                else 
                {
                    Console.WriteLine("Copiando datos");
                    StreamWriter archivo = File.AppendText("datosAuxiliar.txt");
                    archivo.WriteLine(datos);
                    archivo.Close();
                    
                }
            }

        }
        while (datos != null); // se repite hasta que el archivo regrese un valor null
        leerArchivo.Close();
        File.Delete("datos.txt");
        File.Copy("datosAuxiliar.txt", "datos.txt");
        if (File.Exists("datosAuxiliar.txt"))
        {
            File.Delete("datosAuxiliar.txt");
        }

    }

    static void EliminarArchivo()
    {
        if (File.Exists("datos.txt"))
         {
            File.Delete("datos.txt");
            return;   
         }
        Console.WriteLine("El archivo no exite");
    }

    static void Mostrar()
    {
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
                Console.WriteLine("La esad es: " + d[1]);
                Console.WriteLine("La estatura es: " + d[2]);
            }
            
        }
        while (datos != null); // se repite hasta que el archivo regrese un valor null
        leerArchivo.Close();
    }

    static void Agregar()
    {
        StreamWriter archivo = null;
       
        string nombre, edad, estatura;

        while (true)
        {
            Console.WriteLine("Escribe un nombre");
            nombre = Console.ReadLine();
            if (val.ValidarNombre(nombre))
            {
                break;
            }
            //else
            //{
            Console.WriteLine("Error al introducir el nombre");
            //}
        }
        // Console.WriteLine("pasaste nombre");
        while (true)
        {
            Console.WriteLine("Escribe la edad");
            edad = Console.ReadLine();
            if (val.ValidarEdad(edad))
            {
                break;
            }
            else
            {
                Console.WriteLine("Error al introducir el nombre");
            }
        }
        Console.WriteLine("La edad correcta es: " + edad);

        while (true)
        {
            Console.WriteLine("Escribe la estatura");
            estatura = Console.ReadLine();
            if (val.ValidarSexo(estatura))
            {
                break;
            }
            //else
            //{
            Console.WriteLine("Error al introducir la estatura correcta");
            //}
        }
        Console.WriteLine("la estatura es correcta es: " + estatura);

        archivo = File.AppendText("datos.txt");
        archivo.WriteLine(nombre + " , " +  edad + " , " + estatura);
        archivo.Close();

        return;


    }

    static int Menu()
    {
        inicio:
        int opcion = 0;
        Console.WriteLine("1.- Agregar elementos al archivo");
        Console.WriteLine("2.- Eliminar Archivo");
        Console.WriteLine("3.- Eliminar Datos en el Archivo");
        Console.WriteLine("4.- Mostrar Contenido del Archivo");
        Console.WriteLine("5.- Salir");
        Console.WriteLine("Escribe la Opcion del Menu");
        String op =  Console.ReadLine();
        if (val.ValidarEdad(op))
        {
            opcion = int.Parse(op);
        }
        else
        {
            Console.WriteLine("Error");
            goto inicio;
        }
            return opcion;
    }
}
