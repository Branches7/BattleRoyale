using System;

class Armas : Lenda{
  protected string nomeArma;
  protected int dano;
  protected int alcance;
  protected int cadencia;
  protected int precisao;
  protected int capacidadePente;
  protected string mira;
  
  public Armas()
  {
    nomeArma = "M4A1";
    dano = 44;
    alcance = 40;
    cadencia = 65;
    precisao = 50;
    capacidadePente = 30;
    mira = "Mira Holográfica";

    Console.WriteLine("Construtor arma definido: \nArma: {0} \nDano: {1} \nAlcance: {2} \nCadência: {3} \nPrecisão: {4} \nCapacidade do Pente: {5} \nMira: {6}", nomeArma, dano, alcance, cadencia, precisao, capacidadePente, mira);
  }
  
  public Armas(string arma, int dan, int alcan, int caden, int preci, int pente, string mir)
  {
    nomeArma = arma;
    dano = dan;
    alcance = alcan;
    cadencia = caden;
    precisao = preci;
    capacidadePente = pente;
    mira = mir;

    Console.WriteLine("Construtor arma não-definido: \nArma: {0} \nDano: {1} \nAlcance: {2} \nCadência: {3} \nPrecisão: {4} \nCapacidade do Pente: {5} \nMira: {6}", nomeArma, dano, alcance, cadencia, precisao, capacidadePente, mira);
  }
}
