//Clase 5 
using System;

class Program
{
    private static string promedio;
    private static int val2;
    private static int val1;

    //ejercicio 1 
    static void Suma()
    {
        int valor = 30;
        Console.WriteLine(valor);
        int val1, val2;
        Console.WriteLine("Ingrese valor 1:");
        val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese valor 2:");
        val2 = Convert.ToInt32(Console.ReadLine());
        int Respuesta = val1 + val2;
        Console.WriteLine("suma =" + Respuesta);
    }
    //ejer2 
    static void Datos()
    {
        Console.WriteLine("Cual es su nombre;");
        string nombre = Console.ReadLine();
        Console.WriteLine("mucho gusto" + nombre);
    }
    //ejer3
    static int CalEdad()
    {
        Console.WriteLine("Ingrese su año de nacimiento0");
        int yearBorn = Convert.ToInt32(Console.ReadLine());
        int edad = yearBorn - 2024;
        Console.WriteLine("su edad es=", edad);

        static int Suma1(int val1, int val2, int v)
        {
            return val1 + val2;
        }
        int resultado = val2 + val1;
        return resultado;


        static int suma1(int val1, int val2, int val3)
        {
            return val1 + val2 + val3;
        }

        int Promedio = Suma1(30, 20, 40);
        Console.WriteLine("namet tiene prom de" + promedio);
    }
}


        

        
       // funcion es un cloque de codigo reutilizable, por ejemplo suma, que se envia dos numeros 