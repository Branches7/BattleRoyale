using System;

class Jogador{
  protected string idJogador;
  protected string nome;
  protected DateTime nascimento;
  protected int vitorias;
  protected int eliminacoes;
  protected int mortes;
  protected double mediakd;
  
  public Jogador()
  {
    idJogador = "xBr4nch3s";
    nome = "Daniel Branches";
    vitorias = 600;
    eliminacoes = 2000;
    mortes = 1000;
  }
  
  public Jogador(string j, string n, int vit, int eli, int mor)
  {
    idJogador = j;
    nome = n;
    vitorias = vit;
    eliminacoes = eli;
    mortes = mor;
  }
  
  public string j{
    get {return idJogador;}
    set {
      if(value != null && value.Length > 1){
        idJogador = value;
      }
      else{
        Console.WriteLine("ID inválida");
      }
    }
  }
  
  public string n{
    get {return nome;}
    set {
      if(value != null && value.Length > 1){
        nome = value;
      }
      else{
        Console.WriteLine("Nome inválido");
      }
    }
  }
  
  public static int getIdade(DateTime nascimento)
  {
    int idade = DateTime.Now.Year - nascimento.Year;
    if (DateTime.Now.DayOfYear < nascimento.DayOfYear){
      idade -= 1;
    }
    return idade;
  }

  //Número de vitorias, eliminações e mortes serão informados pelo próprio jogador 
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
  public double kd{
    get {return mediakd;}
    set {
      mediakd = value / mortes;
    }
  }
}
