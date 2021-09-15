using System;

class Nacionais : Carro {

  public Nacionais (string c, string m, string mo, double v, int af) : base(c, m, mo, v, af){}

  public override void definirValorVeiculo (double CustoFixo){
    Valor = CustoFixo * 1.5 + 0.2 * CustoFixo + CustoFixo/10;
  }

}