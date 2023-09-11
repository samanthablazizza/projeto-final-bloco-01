namespace projeto_final_bloco_01
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int opcao = 0;

            
            while (true)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("                                                  ");
                Console.WriteLine("                    SAMCEll                       ");
                Console.WriteLine("                                                  ");
                Console.WriteLine("**************************************************");
                Console.WriteLine("             1 - Criar Produto                    ");
                Console.WriteLine("             2 - Listar Todos os Produtos         ");
                Console.WriteLine("             3 - Atualizar Produto                ");
                Console.WriteLine("             4 - Deletar Produto                  ");
                Console.WriteLine("             5 - Sair                             ");
                Console.WriteLine("                                                  ");
                Console.WriteLine("**************************************************");

                Console.Write("\n\nEntre com a opção desejada: ");

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor inteiro de 1 a 5");
                    Console.ResetColor();
                    opcao = 0;
                }
                if (opcao < 1 || opcao > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor inteiro de 1 a 5");
                    Console.ResetColor();
                }
                if (opcao == 5)
                {
                    System.Environment.Exit(0);
                }

            }
        }
    }
}



  
