using System;

class Producto
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al programa en C#!");
        Console.Write("Por favor, escribe tu nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ahora escribe tu edad: ");
        string edad = Console.ReadLine();
        string mensaje = $"Bienvenido {nombre}, tienes {edad} años.";
        Console.WriteLine(mensaje);
    }
}