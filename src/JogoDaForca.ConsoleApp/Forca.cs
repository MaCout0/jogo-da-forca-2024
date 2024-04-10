namespace JogoDaForca.ConsoleApp
{
    public class Forca
    {
        //atributos
        public string palavraSelecionada;
        public int tentativas = 5;
        public int pontos = 0;
        public char[] mostraLetra;
        public char letraUser;


        public void SelecionaPalavra()
        {
            Random aleatorio = new Random();

            string[] frutas = ["ABACATE","ABACAXI","ACEROLA","ACAI","ARACA","BACABA","BACURI","BANANA","CAJU","CARAMBOLA","CUPUACU","GRAVIOLA","GOIABA","JABUTICABA","JENIPAPO","MACA","MANGABA","MANGA","MARACUJA","MURICI","PEQUI",
                    "PITANGA","PITAYA","SAPOTI","TANGERINA","UMBU","UVA","UVAIA"];

            int valorFruta = aleatorio.Next(frutas.Length);

            palavraSelecionada = frutas[valorFruta];
        }

        public void PreencheLertra()
        {
            mostraLetra = new char[palavraSelecionada.Length];
            for (int i = 0; i < mostraLetra.Length; i++)
            {
                mostraLetra[i] = '_';
            }
        }
        
        public void DesenhaForca()
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
        }

        public void VerificaTentativas()
        {
            char letraUserMaiscula = Char.ToUpper(letraUser);
            int aux = 0;
            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                if (palavraSelecionada[i] == letraUserMaiscula)
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

            if (pontos == palavraSelecionada.Length)
            {
                tentativas = -5;
            }
        }

        public void Resultado()
        {
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


