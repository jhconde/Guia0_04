using System;

class Program
{
    static void Main(string[] args)
{
    // Solicitar al usuario que ingrese su nombre
    Console.Write("Ingrese su nombre: ");
    string nombre = Console.ReadLine();

    // Presentar el mensaje con el nombre ingresado
    Console.WriteLine("Hola " + nombre);

    // Mantener la consola abierta hasta que el usuario presione una tecla
    Console.ReadKey();
}
}
