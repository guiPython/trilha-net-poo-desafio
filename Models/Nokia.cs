namespace DesafioPOO.Models;

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Baixando o APK {nomeApp} da Google Play");
        Console.WriteLine($"Instalando o APK {nomeApp} no Nokia");
    }
}
