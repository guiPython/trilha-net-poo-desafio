using DesafioPOO.Models;

var iphone = new Iphone("+55(11)99999-9999", "Iphone X", "1223-223", 128);
var nokia = new Nokia("+55(21)5555-5555", "Nokia G21", "4555-566", 16);
var smartphones = new List<Smartphone> { iphone, nokia };
var apps = new List<string> { "Netflix", "Prime Video" };

foreach (var (smartphone, app) in smartphones.Zip(apps))
{
    smartphone.Ligar();
    smartphone.InstalarAplicativo(app);
    smartphone.ReceberLigacao();
    Console.WriteLine();
}