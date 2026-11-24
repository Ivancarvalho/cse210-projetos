using System;

public class Comentario
{
    private string _nomeAutor;
    private string _texto;

    public Comentario(string nomeAutor, string texto)
    {
        _nomeAutor = nomeAutor;
        _texto = texto;
    }

    public string ObterTextoFormatado()
    {
        return $"- {_nomeAutor}: \"{_texto}\"";
    }
}