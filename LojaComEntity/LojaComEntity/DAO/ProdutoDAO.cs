using LojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.DAO
{
    public class ProdutoDAO
    {
        private EntidadesContext context;

        public ProdutoDAO()
        {
            context = new EntidadesContext();
        }

        public void Create(Produto produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
        }

        public void Update()
        {
            context.SaveChanges();
        }

        public Produto GetById(int id)
        {
            return context.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.Id == id);
        }

        public IList<Produto> GetAllProdutos()
        {
            return context.Produtos.Include(produto => produto.Categoria).OrderBy(produto => produto.Nome).ToList();
        }

        public IList<Produto> GetAllProdutosByCategoriaId(int id)
        {
            return context.Produtos.Where(produto => produto.CategoriaId == id).OrderBy(produto => produto.Nome).ToList();
        }

        public IList<Produto> GetAllProdutosByPreco(decimal preco)
        {
            return context.Produtos.Where(produto => produto.Preco > preco).OrderBy(produto => produto.Preco).ToList();
        }

        public IList<Produto> GetAllProdutosByNameOrPrecoOrCategoria(string nome, decimal preco, string nomeCategoria)
        {

            var produtos = from p in this.context.Produtos select p;
            
            if (!String.IsNullOrEmpty(nome))
            {
                produtos = produtos.Where(produto => produto.Nome == nome);
            }

            if (preco > 0.0m)
            {
                produtos = produtos.Where(produto => produto.Preco == preco);
            }

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                produtos = produtos.Where(produto => produto.Categoria.Nome == nomeCategoria);
            }

            return produtos.ToList();
        }


        public void Remove(Produto produto)
        {
            context.Produtos.Remove(produto);
            context.SaveChanges();
        }

    }
}
