using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices
{
    public interface ICompraUsuarioService
    {
        public Task<CompraUsuario> CarrinhoCompras(string userId);

        public Task<CompraUsuario> ProdutosComprados(string userId, int? id = null);
        public Task<List<CompraUsuario>> MinhasCompras(string userId);

        public Task AdicionarProdutoCarrinho(string UserId, CompraUsuario compraUsuario);
    }
}
