using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            separar a palavra para analizar carcteres individuais

            use case para desenhar a forca
            */

            Random aleatorio = new Random();
            string[] frutas = ["ABACATE","ABACAXI","ACEROLA","ACAI","ARACA","BACABA","BACURI","BANANA","CAJU","CARAMBOLA","CUPUACU","GRAVIOLA","GOIABA","JABUTICABA","JENIPAPO","MACA","MANGABA","MANGA","MARACUJA","MURICI","PEQUI",
                "PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"];
            int valorFruta = aleatorio.Next(frutas.Length);
            string palavraSelecionada = "UVA";//frutas[valorFruta];
            char[] separaPalavra = palavraSelecionada.ToCharArray();
            int tentativas = 5;
            char[] mostraLetra = new char[separaPalavra.Length];
            for (int i = 0; i < mostraLetra.Length; i++)
            {
                mostraLetra[i] = '_';
            }


            while (true)
            {

                Console.WriteLine("Digite uma letra: ");
                char letraUser = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(palavraSelecionada);


                for (int i = 0; i < separaPalavra.Length; i++)
                {

                    if (separaPalavra[i] == letraUser)
                    {
                        mostraLetra[i] = letraUser;
                    }

                    //if (mostraLetra[i] != letraUser)
                    //{
                    //    tentativas--;
                    //}

                }
                Console.WriteLine(new string(mostraLetra));
                
            }
            Console.ReadLine();
        }
    }
}
