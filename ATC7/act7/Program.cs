//act 7 Osone Paula
//defino el array e ingresa los valores
int[] numeros = new int[10];
Console.WriteLine("Ingresa 10 número para generar la lista");

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(Console.ReadLine());
}

//punto 2 suma todo

int aux = 0;

for (int i = 0; i < numeros.Length; i++)
{
     aux = aux + numeros[i];
}

//Console.WriteLine("La suma total es " + aux);

//punto 3 maximo y 4 minimo
var mayorValor = numeros.Max();
var menorValor = numeros.Min();

//Console.WriteLine("El mayor de todos los números es " + mayorValor);
// Console.WriteLine("El menor de todos los números es " + menorValor);

//5 promedio

decimal promedio = Decimal.Divide(aux, numeros.Length);

//Console.WriteLine("Promedio: " + promedio);

// act 6 mostrar todo

Console.WriteLine("Los números ingresados fueron");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

// Respecto al punto 7 en cada ejercicio dejé las impresiones respectivas. 