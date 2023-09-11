using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Acessorio : Produtos
    {
        private string categoria;
        public Acessorio(int id, int tipo, string nome, string marca, decimal preco, string categoria) : base(id, tipo, nome, marca, preco)
        {
            this.categoria = categoria; 
        }
        public string GetCategoria()
        {
            return this.categoria;
        }
        public void SetCor(string categoria)
        {
            this.categoria = categoria;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Categoria: {this.categoria}");
        }
    }
}
