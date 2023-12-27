namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //FEITO
    public class Iphone : Smartphone
    {
        public Iphone(String numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //FEITO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando: {nomeApp}");
        }

        public static void TestarIphone() {
            Console.WriteLine("testando Iphone");
            Nokia nokia = new Nokia("123456789", "Iphone", "1234567890123456789", 128);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Clash royale");
        }


    }
}