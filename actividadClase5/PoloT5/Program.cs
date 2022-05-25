// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//ejercicio clase 5 osone paula andrea

string respuesta = "S";

while (respuesta.ToUpper() == "S")
{
    Console.Clear();

    Console.WriteLine("¿Cuál es tu nombre?");
    string nombre = Console.ReadLine();
    Console.WriteLine($"¡Hola {nombre}!");

    Console.WriteLine("¿Desea continuar? Ingresa S/N");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
} else
{
    Console.WriteLine("Opción no válida");
}
