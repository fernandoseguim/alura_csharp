using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.DAO
{
    public class ProdutoVendaDAO
    {
        private EntidadesContext context;

        public ProdutoVendaDAO()
        {
            context = new EntidadesContext();
        }

        public void Create(ProdutoVenda produtoVenda)
        {
            context.ProdutosVenda.Add(produtoVenda);
            context.SaveChanges();
        }
    }
}
