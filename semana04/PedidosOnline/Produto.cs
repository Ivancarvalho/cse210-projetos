using System;

public class Produto
{
    private string _nome;
    private string _idProduto;
    private double _precoUnitario;
    private int _quantidade;

    public Produto(string nome, string idProduto, double precoUnitario, int quantidade)
    {
        _nome = nome;
        _idProduto = idProduto;
        _precoUnitario = precoUnitario;
        _quantidade = quantidade;
    }

    public double CalcularCustoTotal()
    {
        return _precoUnitario * _quantidade;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public string ObterIdProduto()
    {
        return _idProduto;
    }
}