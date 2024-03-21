using System;

public class Produto
{
    public string Nome { get; set; }
    public int Codigo { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, int codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: R${Preco}");
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        Preco = novoPreco;
        Console.WriteLine($"O preço do produto {Nome} foi atualizado para R${Preco}");
    }
}
