using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forca forca = new Forca();
            forca.SelecionaPalavra();

            forca.PreencheLertra();

            while(forca.tentativas > 0)
            {
                forca.DesenhaForca();
                Console.WriteLine("Digite uma letra: ");
                forca.letraUser = Convert.ToChar(Console.ReadLine());

                forca.VerificaTentativas();
            }
            forca.Resultado();

        }
    }

}


