using projeto_final_bloco_01.Controller;
using projeto_final_bloco_01.Model;
using System;

namespace projeto_final_bloco_01
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int id, tipo, opcao = 0;
            string? nome, marca, cor, categoria;
            decimal preco;

            ProdutoController produto = new();

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
                    Sobre();
                    System.Environment.Exit(0);
                }
                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Criar Produto\n");

                        do
                        {
                            Console.WriteLine("Digite o Tipo da Produto: 1 - Celular  |   2 - Acessório ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        }
                        while (tipo != 1 && tipo != 2);

                        Console.Write("Digite a Marca do Produto: ");
                        marca = Console.ReadLine();
                        marca ??= string.Empty;

                        Console.Write("Digite o Nome do Produto: ");
                        nome = Console.ReadLine();
                        nome ??= string.Empty;

                        Console.Write("Digite o Preço do Produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.Write("Digite a cor do produto: ");
                                cor = Console.ReadLine();
                                cor ??= string.Empty;

                                produto.CriarProduto(new Celular(produto.GerarId(), tipo, nome, preco, marca, cor));
                                
                                break;

                            case 2:
                                Console.Write("Digite a Categoria do Produto: ");
                                categoria = Console.ReadLine();
                                categoria ??= string.Empty;

                                produto.CriarProduto(new Acessorio(produto.GerarId(), tipo, nome, marca, preco, categoria));

                                break;
                        }
                        KeyPress();
                        break;

                    case 2:
                        Console.WriteLine("Listar todos os Produtos\n");
                        produto.ListarProdutos();

                        KeyPress();
                        break;

                    case 3:

                        Console.WriteLine("Atualizar Produto\n");

                        Console.Write("Digite o número de identificação do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produtos = produto.BuscarNaCollection(id);

                        if (produtos != null)
                        {
                            Console.Write("Digite a Marca do Produto: ");
                            marca = Console.ReadLine();
                            marca ??= string.Empty;

                            Console.Write("Digite o Nome do Produto: ");
                            nome = Console.ReadLine();
                            nome ??= string.Empty;

                            Console.Write("Digite o Preço do Produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            tipo = produtos.GetTipo();
                            
                            switch (tipo)
                            {
                                case 1:
                                    Console.Write("Digite a cor do produto: ");
                                    cor = Console.ReadLine();
                                    cor ??= string.Empty;

                                    produto.Atualizar(new Celular(id, tipo, nome, preco, marca, cor));

                                    break;

                                case 2:
                                    Console.Write("Digite a Categoria do Produto: ");
                                    categoria = Console.ReadLine();
                                    categoria ??= string.Empty;

                                    produto.Atualizar(new Acessorio(id, tipo, nome, marca, preco, categoria));

                                    break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"O Produto {id} não foi encontrado!");
                            Console.ResetColor();
                        }
                        KeyPress();
                        break;

                    case 4:
                        Console.WriteLine("Deletar Produto\n");

                        Console.Write("Digite a Id do Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto.Deletar(id);

                        KeyPress();
                        break;
                }
            }
        }
        static void Sobre()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("                                                         ");
            Console.WriteLine("       Projeto Desenvolvido por: Samantha Blazizza       ");
            Console.WriteLine("           E-mail: samantha.blazizza@gmail.com           ");
            Console.WriteLine("               github.com/samanthablazizza               ");
            Console.WriteLine("                                                         ");
            Console.WriteLine("*********************************************************");
        }
        private static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

    }
}
        
    




  
