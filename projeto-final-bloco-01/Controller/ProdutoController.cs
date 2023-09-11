using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projeto_final_bloco_01.Controller
{
    public class ProdutoController
    {
        private readonly List<Produtos> listaProdutos = new();
        int id = 0;

        public void Atualizar(Produtos produto)
        {
            var buscaproduto = BuscarNaCollection(produto.GetId());

            if (buscaproduto != null)
            {
                var index = listaProdutos.IndexOf(buscaproduto);
                listaProdutos[index] = produto;

                Console.WriteLine($"O produto {produto.GetId()} foi atualizado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {produto.GetId()} não foi encontrado!");
                Console.ResetColor();
            }
        }
        public void CriarProduto(Produtos produto)
        {
            listaProdutos.Add(produto);
            Console.WriteLine($"O produto {produto.GetId()} foi cadastrado com sucesso!");

        }
        public void Deletar(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
            {

                if (listaProdutos.Remove(produto) == true)
                    Console.WriteLine($"O produto {id} foi deletado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O produto {id} não foi encontrado!");
                Console.ResetColor();
            }
        }
        public void ListarProdutos()
        {
            foreach (var produto in listaProdutos)
            {
                produto.Visualizar();
            }
        }
        public int GerarId()
        {
            return ++id;
        }
        public Produtos? BuscarNaCollection(int id)
        {
            foreach (var produtos in listaProdutos)
            {
                if (produtos.GetId() == id)
                    return produtos;
            }
            return null;
        }
    }
}
