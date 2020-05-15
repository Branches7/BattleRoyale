using System;

class ModoJogo : Armas{
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
  }


}