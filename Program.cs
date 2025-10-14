using System;
using System.Collections.Generic;

public static class AlgoritmosDeOrdenacao
{
    public static void BubbleSort<T>(T[] vetor, Comparison<T> comparador)
    {
        if (vetor == null || vetor.Length <= 1)
        {
            return;
        }

        int n = vetor.Length;
        bool houveTroca;
        do
        {
            houveTroca = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (comparador(vetor[i], vetor[i + 1]) > 0)
                {
                    Trocar(vetor, i, i + 1);
                    houveTroca = true;
                }
            }
            n--;
        } while (houveTroca);
    }

    private static void Trocar<T>(T[] vetor, int indiceA, int indiceB)
    {
        T temp = vetor[indiceA];
        vetor[indiceA] = vetor[indiceB];
        vetor[indiceB] = temp;
    }
}

public static class EnumerableExtensions
{
    public static void Imprimir<T>(this IEnumerable<T> colecao, string titulo)
    {
        Console.WriteLine(titulo);
        Console.WriteLine($"[ {string.Join(", ", colecao)} ]");
        Console.WriteLine();
    }
}

public class Programa
{
    public static void Main(string[] args)
    {
        string[] nomes = { "Carlos", "Ana", "Zoe", "Bruno", "Daniel" };
        nomes.Imprimir("### Vetor de Nomes Original ###");
        
        AlgoritmosDeOrdenacao.BubbleSort(nomes, (a, b) => a.CompareTo(b));
        nomes.Imprimir("Vetor Ordenado (Crescente):");

        Console.WriteLine("---------------------------------------\n");

        string[] frutas = { "Morango", "Abacaxi", "Laranja", "Uva", "Pera" };
        frutas.Imprimir("### Vetor de Frutas Original ###");
        
        AlgoritmosDeOrdenacao.BubbleSort(frutas, (a, b) => b.CompareTo(a));
        frutas.Imprimir("Vetor Ordenado (Decrescente):");
        
        Console.WriteLine("---------------------------------------\n");
        
        int[] numeros = { 5, 1, 4, 2, 8 };
        numeros.Imprimir("### Vetor de Números Original ###");
        
        AlgoritmosDeOrdenacao.BubbleSort(numeros, (a, b) => a.CompareTo(b));
        numeros.Imprimir("Vetor Ordenado (Crescente):");
    }
}
