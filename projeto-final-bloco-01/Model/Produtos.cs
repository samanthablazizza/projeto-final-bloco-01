using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Produtos
    {
        private int id, tipo;
        private string nome = string.Empty;       
        private decimal preco;

        public Produtos(int id, int tipo, string nome, decimal preco)
        {
            this.id = id;
            this.tipo = tipo;
            this.nome = nome;
            this.preco = preco;

        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetTipo()
        {
            return tipo;
        }
        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public decimal GetPreco()
        {
            return preco;
        }
        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }
        public virtual void Visualizar()
        {
            string tipo = string.Empty;

            switch (this.tipo)
            {
                case 1:
                    tipo = "Celular";
                    break;

                case 2:
                    tipo = "Acessório";
                    break;

            }
            Console.WriteLine("***************************************");
            Console.WriteLine("Informações do Produto");
            Console.WriteLine("***************************************");
            Console.WriteLine($"Identificação do Produto: {this.id}");
            Console.WriteLine($"Tipo de produto: {this.tipo}");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Preço: " + (this.preco).ToString("C"));
        }
    }
}
