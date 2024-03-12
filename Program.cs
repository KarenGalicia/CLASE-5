using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Datos");
            Console.WriteLine("3. Calcular Edad");
            Console.WriteLine("4. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Datos();
                    break;
                case 3:
                    CalEdad();
                    break;
                case 4:
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija nuevamente.");
                    break;
            }
        }
    }

    static void Suma()
    {
        Console.WriteLine("Ingrese valor 1:");
        int val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese valor 2:");
        int val2 = Convert.ToInt32(Console.ReadLine());
        int Respuesta = val1 + val2;
        Console.WriteLine("La suma es: " + Respuesta);
        Console.WriteLine();
    }

    static void Datos()
    {
        Console.WriteLine("Cuál es su nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Mucho gusto, en conocerte" + nombre);
        Console.WriteLine();
    }

    static void CalEdad()
    {
        Console.WriteLine("Ingrese su año de nacimiento:");
        int yearBorn = Convert.ToInt32(Console.ReadLine());
        int edad = 2024 - yearBorn;
        Console.WriteLine("Su edad es: " + edad);
        Console.WriteLine();
    }
}


// funcion es un cloque de codigo reutilizable, por ejemplo suma, que se envia dos numeros 