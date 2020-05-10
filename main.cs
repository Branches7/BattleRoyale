using System;

class MainClass {
  public static void Main (string[] args) {
    Jogador eu = new Jogador();

    Console.Write("ID Jogador: ");
    eu.j = Console.ReadLine();
    Console.WriteLine("Nome inserido: {0}", eu.j);

  }
}