using System.Collections.Generic;
using System;

class Concecionaria{
string localizacao;
string gerente;
int anofund;
List<Carro> carrosdisponiveis = new List<Carro>();
}

public void adicionaCarro(Carro car){
    carrosdisponiveis.Add(car);
  }
}