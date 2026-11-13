using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; // Adição para exceder os requisitos (100%)

    public void Display()
    {
        Console.WriteLine($"Data: {_date} - Humor: {_mood}");
        Console.WriteLine($"Pergunta: {_promptText}");
        Console.WriteLine($"Resposta: {_entryText}");
        Console.WriteLine(); // Linha em branco para separar as entradas
    }
}