using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
  public interface InterfaceCompraUsuarioApp: InterfaceGenericaApp<CompraUsuario>
    {
        public Task<List<CompraUsuario>> GetListCompraUsuario(string idUser);

        public Task<CompraUsuario> CarrinhoCompras(string userId);

        public Task<CompraUsuario> ProdutosComprados(string userId, int? id = null);

        public Task<bool> ConfirmaCompraCarrinhoUsuario(string userId);

        public Task<List<CompraUsuario>> MinhasCompras(string userId);

        public Task AdicionarProdutoCarrinho(string UserId, CompraUsuario compraUsuario);
    }
}
