using System;

class Importados : Carro {

  public Importados (string c, string m, string mo, double v, int af) : base(c, m, mo, v, af){}

  public override void definirValorVeiculo (double CustoFixo){
    Valor = CustoFixo * 3.0 + 0.6 * CustoFixo + CustoFixo/5;
  }

}