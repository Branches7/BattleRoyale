using System;

class Armas : Lenda{
  protected string nomeArma;
  protected int dano;
  protected int alcance;
  protected int cadencia;
  protected int precisao;
  protected int capacidadePente;
  protected string mira;
  
  public Armas(){
    nomeArma = "M4A1";
    if(nomeArma == "M4A1"){
      dano = 44;
      alcance = 40;
      cadencia = 65;
      precisao = 50;
      capacidadePente = 30;
      mira = "Mira Holográfica";
    }
    if(nomeArma == "Krebler"){
      dano = 150;
      alcance = 100;
      cadencia = 89;
      precisao = 95;
      capacidadePente = 12;
      mira = "Mira Longo alcance 5x";
    }
    if(nomeArma == "R99"){
      dano = 32;
      alcance = 25;
      cadencia = 22;
      precisao = 23;
      capacidadePente = 30;
      mira = "Mira do pontinho";
    }
    if(nomeArma == "Peacekeeper"){
      dano = 100;
      alcance = 12;
      cadencia = 50;
      precisao = 60;
      capacidadePente = 6;
      mira = "No scope";
    }
    if(nomeArma == "G7 Scout"){
      dano = 52;
      alcance = 60;
      cadencia = 72;
      precisao = 80;
      capacidadePente = 22;
      mira = "Mira Médio alcance 2x";
    }
  }
  
  public Armas(string arma, int dan, int alcan, int caden, int preci, int pente, string mir)
  {
    nomeArma = arma;
    if(nomeArma == "M4A1"){
      dano = 44;
      alcance = 40;
      cadencia = 65;
      precisao = 50;
      capacidadePente = 30;
      mira = "Mira Holográfica";
    }
    if(nomeArma == "Krebler"){
      dano = 150;
      alcance = 100;
      cadencia = 89;
      precisao = 95;
      capacidadePente = 12;
      mira = "Mira Longo alcance 5x";
    }
    if(nomeArma == "R99"){
      dano = 32;
      alcance = 25;
      cadencia = 22;
      precisao = 23;
      capacidadePente = 30;
      mira = "Mira do pontinho";
    }
    if(nomeArma == "Peacekeeper"){
      dano = 100;
      alcance = 12;
      cadencia = 50;
      precisao = 60;
      capacidadePente = 6;
      mira = "No scope";
    }
    if(nomeArma == "G7 Scout"){
      dano = 52;
      alcance = 60;
      cadencia = 72;
      precisao = 80;
      capacidadePente = 22;
      mira = "Mira Médio alcance 2x";
    }

    Console.WriteLine("Construtor arma não-definido: \nArma: {0} \nDano: {1} \nAlcance: {2} \nCadência: {3} \nPrecisão: {4} \nCapacidade do Pente: {5} \nMira: {6}", nomeArma, dano, alcance, cadencia, precisao, capacidadePente, mira);
  }
}
