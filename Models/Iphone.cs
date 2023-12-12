namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"{nomeApp} instalado com sucesso no seu Iphone modelo {Modelo}")
        }
    }
}