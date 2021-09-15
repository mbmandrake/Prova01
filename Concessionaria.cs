using System;
using System.Collections.Generic;

class Concessionaria {
  private string _localizacao;
  private string _gerentePrincipal;
  private int _anoFundacao;
  private List<Carro> _carrosDisp = new List<Carro>(); 

  public string Localizacao {
    get {return _localizacao;}
    set {_localizacao = value;}
  }

  public string GerentePrincipal {
    get {return _gerentePrincipal;}
    set {_gerentePrincipal = value;}
  }

  public int AnoFundacao {
    get {return _anoFundacao;}
    set {_anoFundacao = value;}
  }

  public Concessionaria(string l, string gp, int af){
    Localizacao = l;
    GerentePrincipal = gp;
    AnoFundacao = af;
  }

  public void AdicionarCarro(Carro x){
    _carrosDisp.Add(x);
  }
  
  public void CalcularPortfolio(){
    double totalPortifolio = 0.0;
    if(_carrosDisp.Count > 0){
      foreach (Carro valor in _carrosDisp){
        totalPortifolio += valor.Valor;
      }
      Console.WriteLine("\n Valor total na Concessionária: R$ " + totalPortifolio);
    }
    else{
      Console.WriteLine("\n Concessionária vazia");
    } 
  }
}