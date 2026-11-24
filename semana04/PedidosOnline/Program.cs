using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1: Cliente residente nos EUA (Frete = $5.00)
        Endereco enderecoEUA = new Endereco("742 Evergreen Terrace", "Springfield", "OR", "USA");
        Cliente clienteEUA = new Cliente("Michael Scott", enderecoEUA);

        Pedido pedido1 = new Pedido(clienteEUA);
        pedido1.AdicionarProduto(new Produto("Teclado Mecânico RGB", "TEC-101", 85.00, 1));
        pedido1.AdicionarProduto(new Produto("Mouse Sem Fio Pro", "MOU-204", 30.00, 2));

        // Pedido 2: Cliente Internacional (Frete = $35.00)
        Endereco enderecoBrasil = new Endereco("Av. T-63, 1290 - Setor Bueno", "Goiânia", "GO", "Brasil");
        Cliente clienteBrasil = new Cliente("Carlos Eduardo", enderecoBrasil);

        Pedido pedido2 = new Pedido(clienteBrasil);
        pedido2.AdicionarProduto(new Produto("Monitor IPS 24 Polegadas", "MON-305", 180.00, 1));
        pedido2.AdicionarProduto(new Produto("Cabo HDMI 2.1 Ultra", "CAB-112", 12.50, 2));
        pedido2.AdicionarProduto(new Produto("Suporte Articulado de Mesa", "SUP-408", 45.00, 1));

        ExibirResumoPedido(1, pedido1);
        ExibirResumoPedido(2, pedido2);
    }

    static void ExibirResumoPedido(int numeroPedido, Pedido pedido)
    {
        Console.WriteLine($"================ PEDIDO #{numeroPedido} ================");
        Console.WriteLine(pedido.ObterEtiquetaEmbalagem());
        Console.WriteLine();
        Console.WriteLine(pedido.ObterEtiquetaEnvio());
        Console.WriteLine();
        Console.WriteLine($"Preço Total do Pedido: ${pedido.CalcularCustoTotal().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine("===========================================\n");
    }
}