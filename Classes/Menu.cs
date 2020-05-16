using System;
using System.IO;

class Menu{
  public void menu(){ // Menu do jogo
    string[] lines = File.ReadAllLines("menu.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }

  public void escolhalenda(){ // Opções de escolha da lenda
    string[] lines = File.ReadAllLines("escolhalenda.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }

  public void escolhaclasse(){ // Opções de escolha da arma
    string[] lines = File.ReadAllLines("escolhaclasse.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }

  public void resultadofinal(){ // Print com todas as escolhas
    string[] lines = File.ReadAllLines("LendaEscolhida.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }
  public void classescolhida(){ // Print com todas as escolhas
    string[] lines = File.ReadAllLines("ClasseArma.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }
}