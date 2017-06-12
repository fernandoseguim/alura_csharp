using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.Entidades
{
    public class Venda
    {
        public int Id { get; set; }
        public int UsuarioID { get; set; }
        public virtual Usuario Cliente { get; set; }
        public virtual IList<ProdutoVenda> ProdutosVenda { get; set; }
    }
}
