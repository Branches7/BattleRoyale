using System;

class Jogador : Menu{
  protected string idJogador;
  protected string nome;
  protected DateTime nascimento;
  protected int vitorias;
  protected float eliminacoes;
  protected float mortes;
  protected double mediakd;
  
  public Jogador()
  {
    idJogador = "xBr4nch3s";
    nome = "Daniel Branches";
    vitorias = 600;
    eliminacoes = 2000f;
    mortes = 1000f;
  }
  
  public Jogador(string j, string n, int vit, float eli, float mor)
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
  public float eli{
    get {return eliminacoes;}
    set {eliminacoes = value;}
  }
  public float mor{
    get {return mortes;}
    set {mortes = value;}
  }
  //A taxa de K/D (Kills / Deaths) é um cálculo feito com base no número de eliminações e número de mortes
  public double kd{
    get {return mediakd;}
    set {mediakd = value;}
  }

  public void historicokd(){
    Console.WriteLine("Após essa experiência, nos informe seus números nas partidas que jogou?\nAo fim iremos informar seu KD, que é feito com base no numero de Eliminações e Mortes");
    Console.Write("Insira seu número de vitórias no jogo: ");
    vit = int.Parse(Console.ReadLine());
    Console.Write("Insira seu número de Eliminações no jogo: ");
    eli = float.Parse(Console.ReadLine());
    Console.Write("Insira seu número de Mortes no jogo: ");
    mor = float.Parse(Console.ReadLine());
    
    //A taxa de K/D (Kills / Deaths) é um cálculo feito com base no número de eliminações e número de mortes
    double kd = eli / mor;
    Console.WriteLine("Seu KD in game é: {0}", kd.ToString("F2"));
  }
}
