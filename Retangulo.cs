public class Retangulo
{
    double largura;
    double altura;

    public Retangulo()
    {
        this.largura = 0;
        this.altura = 0;
    }

    public Retangulo(double ele)
    {
        this.altura = ele;
        this.largura = ele;
    }

    public Retangulo(double alt, double lar)
    {
        this.altura = alt;
        this.largura = lar;
    }

    public double CalcularArea()
    {
        return altura * largura;
    }

    public double CalcularPerimetro()
    {
        return (largura + altura) * 2;
    }

    public void Redimensionar()
    {

    }

    public void Redimensionar(double fator)
    {
        altura *= fator;
        largura *= fator;
    }

    public void Redimensionar(double novaAltura, double NovaLargura)
    {
        altura = novaAltura;
        largura = NovaLargura;
        Console.WriteLine("Dados Atualizados");
    }
}