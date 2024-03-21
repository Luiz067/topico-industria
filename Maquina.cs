using System;

public class Maquina
{
    public int Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Maquina(int id, string marca, string modelo)
    {
        Id = id;
        Marca = marca;
        Modelo = modelo;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Máquina #{Id}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
    }

    public void IniciarProducao()
    {
        Console.WriteLine($"Máquina #{Id} iniciou a produção.");
    }
}
