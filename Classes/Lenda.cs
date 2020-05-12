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
    nomeLenda = "Wraith";
    if(nomeLenda == "Octane"){
      idade = 24;
      habilidadeTatica = "Estimulante";
      habilidadePassiva = "Reparo Rápido";
      ultimate = "Suporte de Salto";
      tipoArmadura = "Level 2";
    }
    else if(nomeLenda == "Mirage"){
      idade = 30;
      habilidadeTatica = "Astúcia";
      habilidadePassiva = "Bis";
      ultimate = "Desaparecer";
      tipoArmadura = "Level 4";
    }
    else if(nomeLenda == "Wraith"){
      idade = 32;
      habilidadeTatica = "Adentrando o Vazio";
      habilidadePassiva = "Vozes do Vazio";
      ultimate = "Fenda Dimensional";
      tipoArmadura = "Level 3";
    }
    else if(nomeLenda == "Pathfinder"){
      idade = 100;
      habilidadeTatica = "Gancho com Garras";
      habilidadePassiva = "Fontes Internas";
      ultimate = "Arma de Tirolesa";
      tipoArmadura = "Evo Shield";
    }
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
      habilidadePassiva = "Vozes do Vazio";
      ultimate = "Fenda Dimensional";
      tipoArmadura = tip;
    }
    else if(nomeLenda == "Pathfinder"){
      idade = 100;
      habilidadeTatica = "Gancho com Garras";
      habilidadePassiva = "Fontes Internas";
      ultimate = "Arma de Tirolesa";
      tipoArmadura = tip;
    }
    Console.WriteLine("Construtor lenda não definido: \nLenda: {0} \nIdade Lenda: {1} \nHabilidade Tática: {2} \nHabilidade Passiva: {3} \nUltimate: {4} \nBody Shield: {5}", nomeLenda, idade, habilidadeTatica, habilidadePassiva, ultimate, tipoArmadura);
  }

  public string nomeL{
    get {return nomeLenda;}
    set {
      switch (nomeL){
        case "Octane":
        nomeLenda = value;
        break;

        case "Mirage":
        nomeLenda = value;
        break;

        case "Wraith":
        nomeLenda = value;
        break;

        case "Pathfinder":
        nomeLenda = value;
        break;

        default:
        Console.WriteLine("Insira uma lenda válida");
        break;
      }
    }
  }

  public string tip{
    get {return tipoArmadura;}
    set {
      switch (tip){
        case "1":
        tipoArmadura = "Level 1";
        break;

        case "2":
        tipoArmadura = "Level 2";
        break;

        case "3":
        tipoArmadura = "Level 3";
        break;

        case "4":
        tipoArmadura = "Level 4";
        break;

        case "Evo":
        tipoArmadura = "Evo Shield";
        break;

        default:
        Console.WriteLine("Insira uma armadura válida");
        break;
      }
    }
  }
  public string Details()
    {
        return nomeLenda + " " + idade.ToString() + " " + habilidadeTatica + " " + habilidadePassiva + " " + ultimate + " " + tipoArmadura;
    } 
}
