
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string  nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine("Seu nome é: "+ Nome + " " + "Sua idade é: " + Idade);
    }
}

public class Program
{
    public static void Main ()
    {
        Pessoa p = new Pessoa("larrisa", 19);
        p.Apresentar();
    }
}