using System;

class MainClass {
  public static void Main (string[] args) {
    Lenda eu = new Lenda();
    
    Console.WriteLine("-------- APEX LEGENS --------");
    Console.WriteLine("SEJA BEM VINDO AO BATTLE ROYALE APEX LEGENS. ︻̷̷┻̿═━一 \nEscolha seu personagem. Monte sua classe. Reúna seu esquadrão. Mostre a todos do que as Lendas são capazes.");
    Console.Write("Insira sua ID: ");
    eu.j = Console.ReadLine();
    Console.Write("Nome: ");
    eu.n = Console.ReadLine();

    Console.Write("Escolha sua lenda: ");
    eu.nomeL = Console.ReadLine();
    Console.Write("Escolha o level de sua armadura: ");
    eu.tip = Console.ReadLine();
  
    Console.WriteLine(eu.Details());
  }
}