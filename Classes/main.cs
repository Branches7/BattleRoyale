using System;
using System.IO;

class MainClass {
  public static void Main (string[] args) {
    ModoJogo eu = new ModoJogo();
    // Apresentação do jogo
    eu.menu();

    // Jogador
    Console.Write("Insira sua ID: ");
    eu.j = Console.ReadLine();
    Console.Write("Nome: ");
    eu.n = Console.ReadLine();

    //-- Escolha da Lenda

    Console.WriteLine();
    eu.escolhalenda();
    eu.LendaEscolha();
    
    // Escolha da Classe de arma
    eu.escolhaclasse();
    eu.ClasseEscolha();
    Console.WriteLine();

    // Escolha Modo de jogo e mapa

    eu.modojogoescolha();
    eu.escolhaModoJogo();


    // Resultado de todas as escolhas

    Console.WriteLine();
    eu.resultadofinal();
    Console.WriteLine();
    eu.classescolhida();
    Console.WriteLine();
    eu.modoescolhido();

    Console.WriteLine();
    eu.historicokd();
    Console.WriteLine("\nObrigado por jogar!!!");
  }
}