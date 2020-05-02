using System;

class Jogador{
  protected string idJogador;
  protected string nome;
  protected DateTime nascimento;
  protected int vitorias;
  protected int eliminacoes;
  protected int mortes;
  
  public Jogador()
  {
    idJogador = "xBr4nch3s";
    nome = "Daniel Branches";
    vitorias = 600;
    eliminacoes = 2000;
    mortes = 1000;
    
    Console.WriteLine("Construtor definido: \nID Jogador: {0} \nNome: {1} \nVitórias: {2} \nEliminações: {3} \nMortes: {4}", idJogador, nome, vitorias, eliminacoes, mortes);
  }
  
  public Jogador(string j, string n, int vit, int eli, int mor)
  {
    idJogador = j;
    nome = n;
    vitorias = vit;
    eliminacoes = eli;
    mortes = mor;
    Console.WriteLine("Construtor não definido: \nID Jogador: {0} \nNome: {1} \nVitórias: {2} \nEliminações: {3} \nMortes: {4}", idJogador, nome, vitorias, eliminacoes, mortes);
  }
  
  public string j{
    get {return idJogador;}
    set {idJogador = value;}
  }
  
  public string n{
    get {return nome;}
    set {nome = value;}
  }
  
  public static int getIdade(DateTime nascimento)
  {
    int idade = DateTime.Now.Year - nascimento.Year;
    if (DateTime.Now.DayOfYear < nascimento.DayOfYear){
      idade -= 1;
    }
    return idade;
  }
  
  public int vit{
    get {return vitorias;}
    set {vitorias = value;}
  }

  public int eli{
    get {return eliminacoes;}
    set {eliminacoes = value;}
  }

  public int mor{
    get {return mortes;}
    set {mortes = value;}
  }
}
