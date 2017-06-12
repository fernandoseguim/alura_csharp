using LojaComEntity.DAO;
using LojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoriaDAO categoriaDAO = new CategoriaDAO();
            ////Categoria categoria = new Categoria() { Nome = "Informática" };
            ////categoriaDAO.Create(categoria);

            ////ProdutoDAO produtoDAO = new ProdutoDAO();
            ////Produto produto = new Produto() { Nome = "Mouse", Preco = (decimal) 53.00, Categoria = categoria };
            ////produtoDAO.Create(produto);
            //ProdutoDAO produtoDAO = new ProdutoDAO();
            //var produtos = produtoDAO.GetAllProdutos()
            //    .Where(p => p.Categoria.Nome.Equals("Multimedia") && p.Preco > 1000)
            //    .OrderBy(p => p.Preco);

            //foreach(var produto in produtos)
            //{
            //    Console.WriteLine(string.Format("Produto: {0} | Preço: {1}", produto.Nome, produto.Preco));
            //}
            //Console.WriteLine(string.Format("Produto {0}, Categoria {1}", produto.Nome, produto.Categoria.Nome));

            //VendaDAO vendaDAO = new VendaDAO();
            //ProdutoVendaDAO produtoVendaDAO = new ProdutoVendaDAO();
            //var venda = new Venda()
            //{
            //    Cliente = new UsuarioDAO().GetById(2)
            //};
            //vendaDAO.Create(venda);

            //List<Produto> Produtos =
            //    new List<Produto>()
            //    {
            //        new ProdutoDAO().GetById(1),
            //        new ProdutoDAO().GetById(2),
            //    };

            //Produtos.ForEach(delegate (Produto produto)
            //{
            //    produtoVendaDAO.Create(new ProdutoVenda() { Venda = venda, Produto = produto });
            //});

            //PessoaFisicaDAO pessoaFisicaDAO = new PessoaFisicaDAO();
            //pessoaFisicaDAO.Create(new PessoaFisica()
            //{
            //    Nome = "Fernando Seguim",
            //    CPF = 360752,
            //    Senha = "123456"
            //});         

            PessoaJuridicaDAO pessoaJuridicaDAO = new PessoaJuridicaDAO();
            pessoaJuridicaDAO.Create(new PessoaJuridica()
            {
                Nome = "Seguim.IT",
                CNPJ = 25801,
                Senha = "789456"
            });

            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
