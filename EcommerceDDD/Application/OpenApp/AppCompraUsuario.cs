using Application.Interface;
using Domain.Interface.InterfaceProducts;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class AppCompraUsuario : InterfaceCompraUsuarioApp
    {
        private readonly ICompraUsuario _ICompraUsuario;
        private readonly ICompraUsuarioService _ICompraUsuarioService;

        public AppCompraUsuario(ICompraUsuario ICompraUsuario, ICompraUsuarioService ICompraUsuarioService)
        {
            _ICompraUsuario = ICompraUsuario;
            _ICompraUsuarioService = ICompraUsuarioService;
        }

        public async Task Add(CompraUsuario Object)
        {
            await _ICompraUsuario.Add(Object);
        }

        public async Task<CompraUsuario> CarrinhoCompras(string userId)
        {
            return await _ICompraUsuarioService.CarrinhoCompras(userId);
        }

        public async Task<CompraUsuario> ProdutosComprados(string userId, int? id = null)
        {
            return await _ICompraUsuarioService.ProdutosComprados(userId, id);
        }

        public async Task<bool> ConfirmaCompraCarrinhoUsuario(string userId)
        {
            return await _ICompraUsuario.ConfirmaCompraCarrinhoUsuario(userId);
        }

        public async Task Delete(CompraUsuario Object)
        {
            await _ICompraUsuario.Delete(Object);
        }

        public async Task<CompraUsuario> GetEntityById(int id)
        {
            return await _ICompraUsuario.GetEntityById(id);
        }

        public async Task<List<CompraUsuario>> GetListCompraUsuario(string idUser)
        {
            return await _ICompraUsuario.GetListCompraUsuario(idUser);
        }

        public async Task<List<CompraUsuario>> List()
        {
            return await _ICompraUsuario.List();
        }

        public async Task Update(CompraUsuario Object)
        {
            await _ICompraUsuario.Update(Object);
        }

        public async Task<List<CompraUsuario>> MinhasCompras(string userId)
        {
            return await _ICompraUsuarioService.MinhasCompras(userId);
        }

        public async Task AdicionarProdutoCarrinho(string UserId, CompraUsuario compraUsuario)
        {
            await _ICompraUsuarioService.AdicionarProdutoCarrinho(UserId, compraUsuario);
        }
    }
}
