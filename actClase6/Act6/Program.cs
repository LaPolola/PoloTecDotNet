//ejercicio clase 6 osone paula andrea
// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroElegido;
int aux = 0;

do
{
    Console.WriteLine("Ingresa un número y adivina cuál eligio la computadora");
    numeroElegido = Int32.Parse(Console.ReadLine());
    aux += 1;

    if (numeroElegido > numeroSecreto)
    {
        Console.WriteLine("El número elegido es mayor, intenta nuevamente");
    }
    else if (numeroElegido == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}. Lo has logrado en {aux} intentos!!");
       
    } 
    else
    {
        Console.WriteLine("El número elegido es menor, intenta nuevamente");
    }
} while (numeroElegido != numeroSecreto);
