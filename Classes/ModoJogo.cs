using System;

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

  public void escolhaModojogo(){
    Console.WriteLine("=== Escolha seu modo de jogo e mapa ===");
    Console.WriteLine("Modo de Jogo:");
    nomemj = Console.ReadLine();
    Console.WriteLine("Escolha o mapa: ");
    map = Console.ReadLine();
  }
}