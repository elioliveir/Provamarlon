class Nacional: Carro{
  override void definirValorVeiculo (double Custofixo){
   Custofixo = CustoFixo *1.5 + 0.2*CustoFixo + CustoFixo/10;
   getValor(Custofixo);

 }
}