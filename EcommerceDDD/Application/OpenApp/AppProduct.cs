using Application.Interface;
using Domain.Interface.InterfaceProducts;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }

        public async Task<List<Product>> ListarProdutosUsuario(string userId)
        {
            return await _IProduct.ListarProdutosUsuario(userId);
        }

        public async Task AddProduct(Product product)
        {
            await _IServiceProduct.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }

        public async Task Add(Product product)
        {
            await _IProduct.Add(product);
        }


        public async Task Delete(Product product)
        {
            await _IProduct.Delete(product);
        }

        public async Task<Product> GetEntityById(int id)
        {
          return  await _IProduct.GetEntityById(id);
        }

        public async Task<List<Product>> List( )
        {
          return  await _IProduct.List();
        }

        public async Task Update(Product product)
        {
            await _IProduct.Update(product);
        }

        public async Task<List<Product>> ListarProdutosComEstoque(string descricao)
        {
           return  await _IServiceProduct.ListarProdutosComEstoque(descricao);
        }

        public async Task<Product> GetProduto(int produtoId)
        {
            return await _IProduct.GetProduto(produtoId);
        }

        public async Task<List<Product>> ListarProdutosCarrinhoUsuario(string userId)
        {
            return await _IProduct.ListarProdutosCarrinhoUsuario(userId);
        }
    }
}
