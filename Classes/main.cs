using System;

class MainClass {
  public static void Main (string[] args) {
    Lenda eu = new Lenda();

    Console.Write("ID Jogador: ");
    eu.j = Console.ReadLine();
    Console.WriteLine("Nome inserido: {0}", eu.j);
    Console.Write("Escolha sua lenda: ");
    eu.nomeL = Console.ReadLine();
    Console.WriteLine("A lenda escolhida foi: {0}", eu.nomeL);
  }
}