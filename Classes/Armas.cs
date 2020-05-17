using System;
using System.IO;

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
    else if(nomeArma == "Krebler"){
      dano = 150;
      alcance = 100;
      cadencia = 89;
      precisao = 95;
      capacidadePente = 12;
      mira = "Mira Longo alcance 5x";
    }
    else if(nomeArma == "R99"){
      dano = 32;
      alcance = 25;
      cadencia = 22;
      precisao = 23;
      capacidadePente = 30;
      mira = "Mira do pontinho";
    }
    else if(nomeArma == "Peacekeeper"){
      dano = 100;
      alcance = 12;
      cadencia = 50;
      precisao = 60;
      capacidadePente = 6;
      mira = "No scope";
    }
    else if(nomeArma == "G7 Scout"){
      dano = 52;
      alcance = 60;
      cadencia = 72;
      precisao = 80;
      capacidadePente = 22;
      mira = "Mira Médio alcance 2x";
    }
  }
  
  public Armas(string arma)
  {
    nomeArma = arma;
  }

  public string arma{
    get {return nomeArma;}
    set {nomeArma = value;}
  }

  public void ClasseEscolha(){ 

    Console.WriteLine("\n---- Escolha sua Classe ----\n");

    Console.Write("Qual será sua escolha?: ");
    arma = Console.ReadLine();
    if(arma == "1" || arma == "M4A1"){
      dano = 44;
      alcance = 40;
      cadencia = 65;
      precisao = 50;
      capacidadePente = 30;
      mira = "Mira Holográfica";
    }
    else if(arma == "2" || arma == "Krebler"){
      dano = 150;
      alcance = 100;
      cadencia = 89;
      precisao = 95;
      capacidadePente = 12;
      mira = "Mira Longo alcance 5x";
    }
    else if(arma == "3" || arma == "R99"){
      dano = 32;
      alcance = 25;
      cadencia = 22;
      precisao = 23;
      capacidadePente = 30;
      mira = "Mira do pontinho";
    }
    else if(arma == "4" || arma == "Peacekeeper"){
      dano = 100;
      alcance = 12;
      cadencia = 50;
      precisao = 60;
      capacidadePente = 6;
      mira = "No scope";
    }
    else if(arma == "5" || arma == "G7 Scout"){
      dano = 52;
      alcance = 60;
      cadencia = 72;
      precisao = 80;
      capacidadePente = 22;
      mira = "Mira Médio alcance 2x";
    }
    File.WriteAllText("ClasseArma.txt", "****Arma escolhida e seus atributos**** \nArma: " +arma + "\ndano: " +dano + "\nAlcance: "+alcance +"\nCadência: " +cadencia +"\nPrecisão: " +precisao + "\nCapacidade do pente: " + capacidadePente + "\nMira: "+ mira);
  } 
}
