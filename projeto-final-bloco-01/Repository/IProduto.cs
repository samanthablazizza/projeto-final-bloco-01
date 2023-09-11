using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IProduto
    {
        public interface IProduto
        {
            public void CriarProduto(Produtos produto);
            public void ListarProdutos();
            public void ConsultarPorId(int id);
            public void Atualizar(Produtos produto);
            public void Deletar(int id);
        }
    }
}
