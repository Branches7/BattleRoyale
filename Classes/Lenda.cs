using System;

class Lenda : Jogador{
  protected string nomeLenda;
  protected int idade;
  protected string habilidadeTatica;
  protected string habilidadePassiva;
  protected string ultimate;
  protected string tipoArmadura;
  
  public Lenda()
  {
    nomeLenda = "Mirage";
    idade = 30;
    habilidadeTatica = "Astúcia";
    habilidadePassiva = "Bis";
    ultimate = "Desaparecer";
    tipoArmadura = "Level 3";

    Console.WriteLine("Construtor Lenda definido: \nLenda: {0} \nIdade Lenda: {1} \nHabilidade Tática: {2} \nHabilidade Passiva: {3} \nUltimate: {4} \nBody Shield: {5}", nomeLenda, idade, habilidadeTatica, habilidadePassiva, ultimate, tipoArmadura);
  }
  
  public Lenda(string nomeL, string tip)
  {
    nomeLenda = nomeL;
    if(nomeLenda == "Octane"){
      idade = 24;
      habilidadeTatica = "Estimulante";
      habilidadePassiva = "Reparo Rápido";
      ultimate = "Suporte de Salto";
      tipoArmadura = tip;
    }
    else if(nomeLenda == "Mirage"){
      idade = 30;
      habilidadeTatica = "Astúcia";
      habilidadePassiva = "Bis";
      ultimate = "Desaparecer";
      tipoArmadura = tip;
    }
    else if(nomeLenda == "Wraith"){
      idade = 32;
      habilidadeTatica = "Adentrando o Vazio";
      habilidadePassiva = "	Vozes do Vazio";
      ultimate = "Fenda Dimensional";
      tipoArmadura = tip;
    }
    else if(nomeLenda == "Pathfinder"){
      idade = 100;
      habilidadeTatica = "Gancho com Garras";
      habilidadePassiva = "	Fontes Internas";
      ultimate = "Arma de Tirolesa";
      tipoArmadura = tip;
    }
    Console.WriteLine("Construtor lenda não definido: \nLenda: {0} \nIdade Lenda: {1} \nHabilidade Tática: {2} \nHabilidade Passiva: {3} \nUltimate: {4} \nBody Shield: {5}", nomeLenda, idade, habilidadeTatica, habilidadePassiva, ultimate, tipoArmadura);
  }

  public string nomeL{
    get {return nomeLenda;}
    set {nomeLenda = value;}
  }

  public string tip{
    get {return tipoArmadura;}
    set {tipoArmadura = value;}
  }
  
}
