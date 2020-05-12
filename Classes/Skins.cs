using System;

class Skins : Armas{
  protected string nomeSLenda;
  protected string sLenda;
  protected string nomeSArma;
  protected string sArma;
  protected string raridade;
  
  public Skins()
  {
    nomeSLenda = "Herói do Povo";
    sLenda = "Mirage";
    nomeSArma = "Avalanche do Além";
    sArma = "M4A1";
    raridade = "Lendária";
  }
  public Skins(string nomesL, string Slend, string nomesA, string Sarm, string rari)
  {
    nomeSLenda = nomesL;
    sLenda = Slend;
    nomeSArma = nomesA;
    sArma = Sarm;
    raridade = rari;

    Console.WriteLine("Construtor Skins não definido: \nNome Skin Lenda: {0} \nLenda: {1} \nNome Skin Arma: {2} \nArma: {3} \nRaridade: {4}", nomeSLenda, sLenda, nomeSArma, sArma, raridade);
  }
}