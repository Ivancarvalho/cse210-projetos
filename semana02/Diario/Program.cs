using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        
        bool keepRunning = true;

        Console.WriteLine("Bem-vindo ao Programa de Diário!");

        while (keepRunning)
        {
            Console.WriteLine("\nPor favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string userResponse = Console.ReadLine();

                    // Adição do campo Humor
                    Console.WriteLine("Como você descreveria o seu humor hoje?");
                    Console.Write("> ");
                    string moodResponse = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._entryText = userResponse;
                    newEntry._mood = moodResponse;

                    theJournal.AddEntry(newEntry);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Qual é o nome do arquivo para carregar? (ex: diario.txt) ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;

                case "4":
                    Console.Write("Qual é o nome do arquivo para salvar? (ex: diario.txt) ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;

                case "5":
                    keepRunning = false;
                    Console.WriteLine("Até logo!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                    break;
            }
        }
    }
}