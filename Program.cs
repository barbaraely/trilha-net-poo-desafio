using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("12345", "Nokia 3310", "123456789", 16);
        Iphone iphone = new Iphone("67890", "iPhone 12", "987654321", 128);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}