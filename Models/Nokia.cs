namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //FEITO
    public class Nokia : Smartphone
    {
        public Nokia(String numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //FEITO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando: {nomeApp}");
        }

        public static void TestarNokia() {
            Console.WriteLine("testando Nokia");
            Nokia nokia = new Nokia("123456789", "Nokia", "1234567890123456789", 128);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Pokemon Go");
        }

    }
}