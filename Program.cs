using System;

class Program
{
    static void Main()
    {
        Industria minhaIndustria = new Industria("Indústria ABC", "Cidade XYZ", 1990);

        LinhaProducao linha1 = new LinhaProducao(1, "Automóveis", 100);
        LinhaProducao linha2 = new LinhaProducao(2, "Eletrodomésticos", 50);

        minhaIndustria.AdicionarLinhaProducao(linha1);
        minhaIndustria.AdicionarLinhaProducao(linha2);

        Maquina maquina1 = new Maquina(101, "MarcaA", "ModeloX");
        Maquina maquina2 = new Maquina(102, "MarcaB", "ModeloY");
        Maquina maquina3 = new Maquina(201, "MarcaC", "ModeloZ");
        Maquina maquina4 = new Maquina(202, "MarcaD", "ModeloW");

        linha1.AdicionarMaquina(maquina1);
        linha1.AdicionarMaquina(maquina2);
        linha2.AdicionarMaquina(maquina3);
        linha2.AdicionarMaquina(maquina4);

        Produto produto1 = new Produto("Carro", 1001, 50000);
        Produto produto2 = new Produto("Geladeira", 2001, 3000);

        minhaIndustria.ExibirInformacoes();
        linha1.ExibirDetalhes();
        maquina1.ExibirInformacoes();
        produto1.ExibirDetalhes();

        linha2.ExibirDetalhes();
        maquina3.ExibirInformacoes();
        produto2.ExibirDetalhes();

        produto1.AtualizarPreco(55000);
        produto1.ExibirDetalhes();
    }
}

