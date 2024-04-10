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
                //operação ternaria
                string cabeça = tentativas <= 4 ? " o" : " ";
                string troncoSuperior = tentativas <= 3 ? "x" : " ";
                string braçoDireito = tentativas <= 2 ? "\\" : " ";
                string braçeEsquerdo = tentativas <= 2 ? "/" : " ";
                string troncoInferior = tentativas <= 1 ? " x" : " ";
                string pernas = tentativas <= 0 ? "/ \\" : " ";

                Console.Clear();
                Console.WriteLine("____________________");
                Console.WriteLine("| /                |");
                Console.WriteLine("|/                {0}", cabeça);
                Console.WriteLine("|                 {0}{1}{2}", braçeEsquerdo, troncoSuperior, braçoDireito);
                Console.WriteLine("|                 {0}", troncoInferior);
                Console.WriteLine("|                 {0}", pernas);
                Console.WriteLine("|                   ");
                Console.WriteLine("|                   ");
                Console.WriteLine("|_________          ");
                Console.WriteLine(new string(mostraLetra));
                
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
                Console.WriteLine("____________________");
                Console.WriteLine("| /                |");
                Console.WriteLine("|/                {0}", " o");
                Console.WriteLine("|                 {0}{1}{2}", "/", "x", @"\");
                Console.WriteLine("|                 {0}", " x");
                Console.WriteLine("|                 {0}", "/ \\");
                Console.WriteLine("|                   ");
                Console.WriteLine("|                   ");
                Console.WriteLine("|_________          ");
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
