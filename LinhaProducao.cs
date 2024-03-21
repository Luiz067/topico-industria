using System;
using System.Collections.Generic;

public class LinhaProducao
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public List<Maquina> Maquinas { get; set; }

    public LinhaProducao(int numero, string tipo, int capacidade)
    {
        Numero = numero;
        Tipo = tipo;
        Capacidade = capacidade;
        Maquinas = new List<Maquina>();
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Linha de Produção #{Numero}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Capacidade: {Capacidade} produtos por hora");
    }

    public void AdicionarMaquina(Maquina maquina)
    {
        Maquinas.Add(maquina);
        Console.WriteLine($"Máquina #{maquina.Id} adicionada à linha de produção #{Numero}.");
    }
}
