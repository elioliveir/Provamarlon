class Importado : Carro{



 override void definirValorVeiculo (double Custofixo){
   Custofixo = (CustoFixo *3.0 + 0.6*CustoFixo + CustoFixo/5);
   getValor(Custofixo);

 }
  
}