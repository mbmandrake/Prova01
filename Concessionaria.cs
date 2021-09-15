using System;
using System.Collections.Generic;

class Concessionaria {
  private string _localizacao;
  private string _gerentePrincipal;
  private int _anoFundacao;
  private List<Carro> _carrosDisp; 

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

  public List<Carro> CarrosDisp {
    get {return _carrosDisp;}
    //set {_carrosDisp.Add(value;)}
  }

  public Concessionaria(string l, string gp, int af){
    Localizacao = l;
    GerentePrincipal = gp;
    AnoFundacao = af;
  }

  public void AdicionarCarro(Carro x){
    this._carrosDisp.Add(x);
  }

  public void CalcularPortfolio(){
    double totalPortifolio;
    if(CarrosDisp != null){
      foreach (Carro valor in CarrosDisp){
        Console.WriteLine(valor.Valor);
      }
    }
    else{
      Console.WriteLine("\n Concessionária vazia");
    } 
  }
}