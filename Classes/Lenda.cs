using System;
using System.IO;

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
    tipoArmadura = tip;
  }

  public string nomeL{
    get {return nomeLenda;}
    set {nomeLenda = value;}
  }

  public string tip{
    get {return tipoArmadura;}
    set {tipoArmadura = value;}
  }

  public void LendaEscolha(){ 

    Console.WriteLine("\n---- Escolha sua Lenda ----\n ");

    Console.Write("Lenda: ");
    nomeL = Console.ReadLine();
    if(nomeL == "Octane" || nomeL == "octane"){
      idade = 24;
      habilidadeTatica = "Estimulante";
      habilidadePassiva = "Reparo Rápido";
      ultimate = "Suporte de Salto";
    }
    else if(nomeL == "Mirage" || nomeL == "mirage"){
      idade = 30;
      habilidadeTatica = "Astúcia";
      habilidadePassiva = "Bis";
      ultimate = "Desaparecer";
    }
    else if(nomeL == "Wraith" || nomeL == "wraith"){
      idade = 32;
      habilidadeTatica = "Adentrando o Vazio";
      habilidadePassiva = "Vozes do Vazio";
      ultimate = "Fenda Dimensional";
    }
    else if(nomeL == "Pathfinder" || nomeL == "pathfinder"){
      idade = 100;
      habilidadeTatica = "Gancho com Garras";
      habilidadePassiva = "Fontes Internas";
      ultimate = "Arma de Tirolesa";
    }
    Console.WriteLine();
    Console.WriteLine("=== Armaduras ===\n");
    Console.WriteLine("1 - Level 1(Cura Rápida)\n2 - Level 2(Absorve mais dano)\n3 - Level 3(Cura sozinho desde que esteja fora de combate)\n4 - Evo Shield(Evolui a proteção a cada dano que causar durante a partida)");
    Console.Write("Escolha qual será o level de sua armadura: ");
    tip = Console.ReadLine();

    if(tip == "1" || tip == "Level 1"){
      tip = "Level 1(Cura Rápida)";
    }
    else if (tip == "2" || tip == "Level 2"){
      tip = "Level 2(Absorve mais dano)";
    }
    else if (tip == "3" || tip == "Level 3"){
      tip = "Level 3(Cura sozinho desde que esteja fora de combate)";
    }
    else if (tip == "4" || tip == "Evo Shield"){
      tip = "Evo Shield(Evolui a proteção a cada dano que causar durante a partida)";
    }

    File.WriteAllText("LendaEscolhida.txt", "Jogador: "+ idJogador +"\nNome do jogador: " + nome +  "\n**Lenda Escolhida por "+ idJogador +"**\nLenda: " +nomeL + "\nIdade: " +idade + "\nHabilidade Tática: "+habilidadeTatica +"\nHabilidade Passiva: " +habilidadePassiva + "\nHabilidade Ultimate: " + ultimate + "\nArmadura Escolhida: "+ tip);
  } 
}
