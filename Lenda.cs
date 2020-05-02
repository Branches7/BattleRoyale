using System;

class Lenda : Jogador{
  protected string nomeLenda;
  protected int idade;
  protected string habilidadeTatica;
  protected string habilidadePassiva;
  protected string ultimate;
  protected string tipoArmadura;
  
  public Lenda()
  {
    nomeLenda = "Mirage";
    idade = 30;
    habilidadeTatica = "Astúcia";
    habilidadePassiva = "Bis";
    ultimate = "Desaparecer";
    tipoArmadura = "Level 3";

    Console.WriteLine("Construtor Lenda definido: \nLenda: {0} \nIdade Lenda: {1} \nHabilidade Tática: {2} \nHabilidade Passiva: {3} \nUltimate: {4} \nBody Shield: {5}", nomeLenda, idade, habilidadeTatica, habilidadePassiva, ultimate, tipoArmadura);
  }
  
  public Lenda(string nomeL, int id, string htatic, string hpassi, string ult, string tip)
  {
    nomeLenda = nomeL;
    idade = id;
    habilidadeTatica = htatic;
    habilidadePassiva = hpassi;
    ultimate = ult;
    tipoArmadura = tip;

    Console.WriteLine("Construtor lenda não definido: \nLenda: {0} \nIdade Lenda: {1} \nHabilidade Tática: {2} \nHabilidade Passiva: {3} \nUltimate: {4} \nBody Shield: {5}", nomeLenda, idade, habilidadeTatica, habilidadePassiva, ultimate, tipoArmadura);
  }
}
