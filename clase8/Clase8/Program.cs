﻿//Clase 8 Osone Paula Andrea

//1
int[,] numeros;

//2

Console.WriteLine("Ingresa las dimensiones de la matriz, filas y columnas");
int filas = int.Parse(Console.ReadLine());
int columnas = int.Parse(Console.ReadLine());

numeros = new int[filas, columnas];

//3

double[] promedio;

//4

for (int i = 0; i < filas; i++)
{

    for (int j = 0; j < columnas; j++)
    {
        Console.WriteLine($"Ingresa un numero en la posicion {(i + 1)}, {(j + 1)} de la matriz");
        numeros[i,j] = int.Parse(Console.ReadLine());
    }
}

//5 

Console.WriteLine("Tu matriz");

for (int i = 0; i < filas; i++)
{

    for (int j = 0; j < columnas; j++)
    {
        Console.Write(numeros[i,j] + " ");
        
    } 
    Console.WriteLine("");
}

// 6 
promedio = new double[columnas];
int suma;

for (int j = 0; j < columnas; j++)
{
    suma = 0;
    for(int i = 0; i < filas; i++)
    {
        suma += numeros[i, j];
    }
    promedio[j] = (Double)Decimal.Divide(suma, filas);
}

//7

Console.WriteLine("Tu vector promedio es");
for (int i = 0; i < columnas; i++)
{
    Console.Write(promedio[i] + " ");
}