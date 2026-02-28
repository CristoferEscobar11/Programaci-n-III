using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    const int TOTAL_NUMEROS = 10_000_000;
    const int BUSQUEDAS = 1000;
    const string ARCHIVO = "numeros.txt";

    static void Main()
    {
        // 1. Generar archivo si no existe
        if (!File.Exists(ARCHIVO))
        {
            Console.WriteLine("Generando archivo de números...");
            GenerarArchivo();
        }

        // 2. Cargar datos
        Console.WriteLine("Cargando datos...");
        var lista = new List<int>();
        var arbol = new SortedSet<int>();
        var hash = new HashSet<int>();

        foreach (var linea in File.ReadLines(ARCHIVO))
        {
            int numero = int.Parse(linea);
            lista.Add(numero);
            arbol.Add(numero);
            hash.Add(numero);
        }

        // 3. Generar búsquedas aleatorias
        var random = new Random();
        int[] busquedas = new int[BUSQUEDAS];
        for (int i = 0; i < BUSQUEDAS; i++)
            busquedas[i] = random.Next(-50_000_000, 50_000_001);

        // 4. Medir tiempos
        double tiempoLista = MedirBusqueda(lista, busquedas);
        double tiempoArbol = MedirBusqueda(arbol, busquedas);
        double tiempoHash = MedirBusqueda(hash, busquedas);

        // 5. Mostrar tabla
        Console.WriteLine("\nRESULTADOS:");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Estructura        | Tiempo promedio   |     Complejidad");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"Lista             | {tiempoLista:F2} ms         | O(n)");
        Console.WriteLine($"Árbol (SortedSet) | {tiempoArbol:F6} ms         | O(log n)");
        Console.WriteLine($"HashSet           | {tiempoHash:F6}  ms         | O(1)");
        Console.WriteLine("-----------------------------------------------------------");

        Console.ReadKey();
    }

    // ================= MÉTODOS =================

    static void GenerarArchivo()
    {
        var random = new Random();
        using (var writer = new StreamWriter(ARCHIVO))
        {
            for (int i = 0; i < TOTAL_NUMEROS; i++)
            {
                int numero = random.Next(-50_000_000, 50_000_001);
                writer.WriteLine(numero);
            }
        }
    }

    static double MedirBusqueda(ICollection<int> estructura, int[] busquedas)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        foreach (int b in busquedas)
            estructura.Contains(b);

        stopwatch.Stop();
        return stopwatch.Elapsed.TotalMilliseconds / busquedas.Length;
    }
}
