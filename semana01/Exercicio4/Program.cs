using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int usuarioNumero = -1;

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        while (usuarioNumero != 0)
        {
            Console.Write("Insira o número: ");
            usuarioNumero = int.Parse(Console.ReadLine());

            if (usuarioNumero != 0)
            {
                numeros.Add(usuarioNumero);
            }
        }

        int soma = 0;
        int maior = numeros[0];

        foreach (int numero in numeros)
        {
            soma += numero;
            if (numero > maior)
            {
                maior = numero;
            }
        }

        double media = (double)soma / numeros.Count;

        Console.WriteLine($"A soma é: {soma}");
        Console.WriteLine($"A média é: {media}");
        Console.WriteLine($"O maior número é: {maior}");
    }
}