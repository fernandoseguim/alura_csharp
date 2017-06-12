using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.DAO
{
    public class VendaDAO
    {
        private EntidadesContext context;

        public VendaDAO()
        {
            context = new EntidadesContext();
        }

        public void Create(Venda venda)
        {
            context.Vendas.Add(venda);
            context.SaveChanges();
        }

        public void Update()
        {
            context.SaveChanges();
        }

        public Venda GetById(int id)
        {
            return context.Vendas.FirstOrDefault(venda => venda.Id == id);
        }

        public void Remove(Venda venda)
        {
            context.Vendas.Remove(venda);
            context.SaveChanges();
        }
    }
}
