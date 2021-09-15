using System;

class Program {
  public static void Main (string[] args) {

    Nacionais carro1 = new Nacionais ("a", "b", "c", 0.0, 1000);
    
    Importados carro2 = new Importados("a", "b", "c", 0.0, 1000);

    Concessionaria con = new Concessionaria("Vitória", "Matheus", 2021);

    carro1.definirValorVeiculo(1000);
    Console.WriteLine ("\n Valor carro Nacional: R$ " + carro1.Valor);

    carro2.definirValorVeiculo(1000);
    Console.WriteLine ("\n Valor carro Importado: R$ " + carro2.Valor);

    con.CalcularPortfolio();

    con.AdicionarCarro(carro1);
    con.AdicionarCarro(carro2);

    con.CalcularPortfolio();

  }
}