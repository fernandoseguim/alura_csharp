using LojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.DAO
{
    public class CategoriaDAO
    {
        private EntidadesContext context;

        public CategoriaDAO()
        {
            context = new EntidadesContext();
        }

        public void Create(Categoria categoria)
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
        }

        public void Update()
        {
            context.SaveChanges();
        }

        public Categoria GetById(int id)
        {
            return context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
        }

        public Categoria GetProdutosByCategoryId(int id)
        {
            return context.Categorias.Include(categoria => categoria.Produtos).FirstOrDefault(categoria => categoria.Id == id);
        }

        public void Remove(Categoria categoria)
        {
            context.Categorias.Remove(categoria);
            context.SaveChanges();
        }
    }
}
