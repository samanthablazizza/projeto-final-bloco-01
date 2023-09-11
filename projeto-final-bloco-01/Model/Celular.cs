using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Celular : Produtos
    {
        private string cor = string.Empty;
        public Celular(int id, int tipo, string nome, decimal preco, string cor) : base(id, tipo, nome, preco)
        {
            this.cor = cor; 
        }
        public string GetCor()
        { 
            return this.cor;
        }
        public void SetCor(string cor)
        {
            this.cor = cor;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Cor: {this.cor}");
        }

    }
}
