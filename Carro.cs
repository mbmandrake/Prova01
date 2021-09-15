using System;

class Carro{

  private string _cor;
  private string _marca;
  private string _modelo;
  private double _valor;
  private int _anoFabric;

  public Carro(string c, string m, string mo, double v, int af){
    Cor = c;
    Marca = m;
    Modelo = mo;
    Valor = v;
    AnoFabric = af;
  }

  public string Cor {
    get {return _cor;}
    set {_cor = value;}
  }

  public string Marca {
    get {return _marca;}
    set {_marca = value;}
  }

  public string Modelo {
    get {return _modelo;}
    set {_modelo = value;}
  }

  public double Valor {
    get {return _valor;}
    set {_valor = value;}
  }

  public int AnoFabric {
    get {return _anoFabric;}
    set {_anoFabric = value;}
  }

  public virtual void definirValorVeiculo (double CustoFixo){}
}