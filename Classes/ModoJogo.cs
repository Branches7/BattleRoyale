using System;

class ModoJogo : Skins{
  protected string nomemodojogo;
  protected int qtdplayers;
  protected string mapa;
  
  public ModoJogo()
  {
    nomemodojogo = "Duos";
    qtdplayers = 100;
    mapa = "King Scanion";
  }

  public ModoJogo(string nomemj, int qtdplay, string map)
  {
    nomemodojogo = nomemj;
    qtdplayers = qtdplay;
    mapa = map;

    Console.WriteLine("Construtor Modo de Jogo não definido: \nNome do modo de jogo: {0} \nQuantidade de Players: {1} \nMapa: {2}", nomemodojogo, qtdplayers, mapa);
  }
}