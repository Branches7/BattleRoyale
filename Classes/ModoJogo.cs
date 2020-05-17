using System;
using System.IO;

class ModoJogo : Armas{
  protected string nomemodojogo;
  protected string mapa;
  
  public ModoJogo()
  {
    nomemodojogo = "Duos";
    mapa = "King Scanion";
  }

  public ModoJogo(string nomemj, string map)
  {
    nomemodojogo = nomemj;
    mapa = map;
  }
  
  public string nomemj{
    get {return nomemodojogo;}
    set {
      if(value != null && value.Length > 1){
        nomemodojogo = value;
      }
      else{
        Console.WriteLine("Modo de jogo inválido");
      }
    }
  }

  public string map{
    get {return mapa;}
    set {mapa = value;}
  }

  public void escolhaModoJogo(){
    Console.WriteLine("=== Escolha seu modo de jogo e mapa ===");
    Console.WriteLine("Modo de Jogo:");
    nomemj = Console.ReadLine();
    if(nomemj == "1" || nomemj == "solo"){
      nomemj = "Solo";
    }
    else if(nomemj == "2" || nomemj == "duos"){
      nomemj = "Duos";
    }
    else if(nomemj == "3" || nomemj == "trios"){
      nomemj = "Trios";
    }
    
    
    Console.WriteLine("Escolha o mapa: ");
    map = Console.ReadLine();
    if(map == "1" || map == "king scanion"){
      map = "King Scanion";
    }
    else if(map == "2" || map == "worlds edge"){
      map = "World's' Edge";
    }

    File.WriteAllText("ModoJogoEscolhido.txt", "==== Modo De Jogo e Mapa ==== \nModo de jogo escolhido: " + nomemj + "\nMapa escolhido: " + map);
  }
}