using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("O diário está vazio.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                // Usando ~|~ para separar, pois é improvável que o usuário digite isso
                outputFile.WriteLine($"{e._date}~|~{e._promptText}~|~{e._entryText}~|~{e._mood}");
            }
        }
        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Arquivo não encontrado!");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _entries.Clear(); // Limpa as entradas antigas antes de carregar as novas

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            
            // Verifica se tem 4 partes para evitar travar com linhas em branco
            if (parts.Length == 4) 
            {
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];
                newEntry._mood = parts[3];
                _entries.Add(newEntry);
            }
        }
        Console.WriteLine("Diário carregado com sucesso!");
    }
}