using System;
using System.Collections.Generic;
using System.Linq;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;
    private static readonly Random _random = new Random();

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavrasSeparadas = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string item in palavrasSeparadas)
        {
            _palavras.Add(new Palavra(item));
        }
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        List<Palavra> palavrasVisiveis = _palavras.Where(p => !p.EstaOculta()).ToList();

        if (palavrasVisiveis.Count == 0)
        {
            return;
        }

        int quantidadeReal = Math.Min(numeroParaOcultar, palavrasVisiveis.Count);

        for (int i = 0; i < quantidadeReal; i++)
        {
            int indiceAleatorio = _random.Next(palavrasVisiveis.Count);
            palavrasVisiveis[indiceAleatorio].Ocultar();
            palavrasVisiveis.RemoveAt(indiceAleatorio);
        }
    }

    public string ObterTexto()
    {
        List<string> textoRenderizado = new List<string>();

        foreach (Palavra palavra in _palavras)
        {
            textoRenderizado.Add(palavra.ObterTexto());
        }

        return $"{_referencia.ObterTexto()} - {string.Join(" ", textoRenderizado)}";
    }

    public bool EstaCompletamenteOculta()
    {
        return _palavras.All(p => p.EstaOculta());
    }
}