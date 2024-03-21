using System;
using System.Collections.Generic;

public class Industria
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
    public List<LinhaProducao> LinhasProducao { get; set; }

    public Industria(string nome, string localizacao, int anoFundacao)
    {
        Nome = nome;
        Localizacao = localizacao;
        AnoFundacao = anoFundacao;
        LinhasProducao = new List<LinhaProducao>();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Indústria: {Nome}");
        Console.WriteLine($"Localização: {Localizacao}");
        Console.WriteLine($"Ano de Fundação: {AnoFundacao}");
    }

    public void AdicionarLinhaProducao(LinhaProducao linhaProducao)
    {
        LinhasProducao.Add(linhaProducao);
        Console.WriteLine($"Linha de Produção #{linhaProducao.Numero} adicionada à indústria.");
    }
}

