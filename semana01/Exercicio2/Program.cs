using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a sua nota numérica: ");
        string input = Console.ReadLine();
        int nota = int.Parse(input);

        string letra = "";

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        Console.WriteLine($"Sua nota conceitual é: {letra}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns, você foi aprovado no curso!");
        }
        else
        {
            Console.WriteLine("Continue se esforçando, boa sorte na próxima vez!");
        }
    }
}