using System;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string[] frutas = ["ABACATE","ABACAXI","ACEROLA","ACAI","ARACA","BACABA","BACURI","BANANA","CAJU","CARAMBOLA","CUPUACU","GRAVIOLA","GOIABA","JABUTICABA","JENIPAPO","MACA","MANGABA","MANGA","MARACUJA","MURICI","PEQUI",
                "PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"];
            int valorFruta = aleatorio.Next(frutas.Length);
            string palavraSelecionada = frutas[valorFruta];
            char[] separaPalavra = palavraSelecionada.ToCharArray();
            int tentativas = 5;
            int pontos = 0;
            char[] mostraLetra = new char[separaPalavra.Length];
            for (int i = 0; i < mostraLetra.Length; i++)
            {
                mostraLetra[i] = '_';
            }


            while (tentativas > 0)
            {
                Console.Clear();
                switch (tentativas)
                {
                    case 5:
                        Console.WriteLine("____________________" +
                                        "\n|/                  " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|_________          ");
                        Console.WriteLine(new string(mostraLetra));
                        break;
                    case 4:
                        Console.WriteLine("____________________" +
                                        "\n|/                 o" +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|_________          ");
                        Console.WriteLine(new string(mostraLetra));
                        break;
                    case 3:
                        Console.WriteLine("____________________" +
                                        "\n|/                 o" +
                                        "\n|                 | " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|_________          ");
                        Console.WriteLine(new string(mostraLetra));
                        break;
                    case 2:
                        Console.WriteLine("____________________" +
                                        "\n|/                 o" +
                                        "\n|                 |x" +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|_________          ");
                        Console.WriteLine(new string(mostraLetra));
                        break;
                    case 1:
                        Console.WriteLine("____________________" +
                                        "\n|/                 o" +
                                        "\n|                 |x|" +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|                   " +
                                        "\n|_________          ");
                        Console.WriteLine(new string(mostraLetra));
                        break;
                }
                Console.WriteLine("Digite uma letra: ");
                char letraUser = Convert.ToChar(Console.ReadLine());
                char letraUserMaiscula = Char.ToUpper(letraUser);
                Console.WriteLine(palavraSelecionada);
                int aux = 0;


                for (int i = 0; i < separaPalavra.Length; i++)
                {
                    if (separaPalavra[i] == letraUserMaiscula)
                    {
                        mostraLetra[i] = letraUser;
                        aux++;
                        pontos++;
                    }
                    
                }

                if (aux == 0)
                {
                    tentativas--;
                }
                
                if(pontos == separaPalavra.Length)
                {
                    tentativas = -5;
                }

            }
            if (tentativas == 0)
            {
                Console.Clear();
                Console.WriteLine("____________________" +
                                "\n|/                 o" +
                                "\n|                 |x|" +
                                "\n|                  x" +
                                "\n|                   " +
                                "\n|                   " +
                                "\n|                   " +
                                "\n|_________          ");
                Console.WriteLine(new string(mostraLetra));
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            }
            if (tentativas == -5)
            {
                Console.Clear();
                Console.WriteLine("GAME WIN");
                Console.WriteLine($"Parabéns as palavra era: {new string(mostraLetra)}");
                Console.ReadLine();
            }
        }
    }
}
