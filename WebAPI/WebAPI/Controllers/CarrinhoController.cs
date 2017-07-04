using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.DAO;
using WebAPI.Models;

namespace WebAPI.Areas.CarrinhoDeCompra.Controllers
{
    public class CarrinhoController : ApiController
    {
        private HttpResponseMessage _response;

        [HttpGet, ActionName("BuscaCarrinho")]
        public HttpResponseMessage Get([FromUri] long id)
        {
            try
            {
                CarrinhoDAO dao = new CarrinhoDAO();
                Carrinho carrinho = dao.Busca(id);

                _response = Request.CreateResponse(HttpStatusCode.OK, carrinho);
            }
            catch (KeyNotFoundException)
            {
                var msg = string.Format("O carrinho id = {0} não foi encontrado", id);
                var error = new HttpError(msg);

                _response = Request.CreateResponse(HttpStatusCode.NotFound, error);
            }
            
            return _response;
        }
        
        public HttpResponseMessage Post([FromBody] Carrinho carrinho)
        {

            CarrinhoDAO dao = new CarrinhoDAO();
            dao.Adiciona(carrinho);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            string location = Url.Link("DefaultApi", new { controller = "carrinho", id = carrinho.Id });
            response.Headers.Location = new Uri(location);

            return response;
        }

        [HttpPost, HttpDelete]
        [Route("api/carrinho/{idCarrinho}/produto/{idProduto}")]
        public HttpResponseMessage Remove([FromUri] int idCarrinho, [FromUri] int idProduto)
        {
            var dao = new CarrinhoDAO();
            var carrinho = dao.Busca(idCarrinho);
            carrinho.Remove(idProduto);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost, HttpPut]
        [Route("api/carrinho/{id}/produtos/{produtoId}/quantidade")]
        public HttpResponseMessage Update([FromBody] Produto produto, [FromUri] long id, [FromUri] long produtoId)
        {
            Carrinho carrinho = new CarrinhoDAO().Busca(id);

            carrinho.TrocaQuantidade(produto);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
}
