using System;
using System.Collections.Generic;
using System.Text;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularCustoTotal()
    {
        double subtotal = 0;

        foreach (Produto produto in _produtos)
        {
            subtotal += produto.CalcularCustoTotal();
        }

        double custoEnvio = _cliente.MoraNosEUA() ? 5.00 : 35.00;
        return subtotal + custoEnvio;
    }

    public string ObterEtiquetaEmbalagem()
    {
        StringBuilder etiqueta = new StringBuilder();
        etiqueta.AppendLine("ETIQUETA DE EMBALAGEM:");

        foreach (Produto produto in _produtos)
        {
            etiqueta.AppendLine($"- {produto.ObterNome()} (ID: {produto.ObterIdProduto()})");
        }

        return etiqueta.ToString().TrimEnd();
    }

    public string ObterEtiquetaEnvio()
    {
        return $"ETIQUETA DE ENVIO:\n{_cliente.ObterNome()}\n{_cliente.ObterEndereco().ObterEnderecoCompleto()}";
    }
}