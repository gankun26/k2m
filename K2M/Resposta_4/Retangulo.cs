
class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double Area { get; set; }    


    public Retangulo ( double altura, double largura )
    {
        this.Altura = altura;
        this.Largura = largura;
        this.Area = altura * largura;
    }
    public void CalculaArea()
    {
        Console.WriteLine("A area é : " + Area);
    }
}

public class Program
{
    public static void Main ()
    {
        Retangulo ret = new Retangulo(5, 3);
        ret.CalculaArea();
    }
}