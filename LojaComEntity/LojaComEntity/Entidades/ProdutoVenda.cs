using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.Entidades
{
    public class ProdutoVenda
    {
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public int VendaId { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
