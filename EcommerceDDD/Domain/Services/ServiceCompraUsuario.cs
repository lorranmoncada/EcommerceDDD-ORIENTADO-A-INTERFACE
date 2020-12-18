using Domain.Interface.InterfaceProducts;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceCompraUsuario : ICompraUsuarioService
    {
        private readonly ICompraUsuario _ICompraUsuario;
        private readonly ICompra _ICompra;

        public ServiceCompraUsuario(ICompraUsuario ICompraUsuario, ICompra ICompra)
        {
            _ICompraUsuario = ICompraUsuario;
            _ICompra = ICompra;
        }

        public async Task AdicionarProdutoCarrinho(string UserId, CompraUsuario compraUsuario)
        {
            var compra = await _ICompra.CompraPorEstado(UserId, EnumEstadoCompra.Produto_Carrinho);
            if (compra == null)
            {
                compra = new Compra
                {
                    UserId = UserId,
                    Estado = EnumEstadoCompra.Produto_Carrinho
                };
                await _ICompra.Add(compra);
            }

            if (compra.Id > 0)
            {
                compraUsuario.IdCompra = compra.Id;
                await _ICompraUsuario.Add(compraUsuario);
            }
        }

        public async Task<CompraUsuario> CarrinhoCompras(string userId)
        {
            return await _ICompraUsuario.ProdutosCompradosPorEstado(userId, EnumEstadoCompra.Produto_Carrinho);
        }

        public async Task<List<CompraUsuario>> MinhasCompras(string userId)
        {
            return await _ICompraUsuario.MinhasCompradosPorEstado(userId, EnumEstadoCompra.Produto_Comprado);
        }

        public async Task<CompraUsuario> ProdutosComprados(string userId, int? id =null)
        {
            return await _ICompraUsuario.ProdutosCompradosPorEstado(userId, EnumEstadoCompra.Produto_Comprado, id);
        }
    }
}
