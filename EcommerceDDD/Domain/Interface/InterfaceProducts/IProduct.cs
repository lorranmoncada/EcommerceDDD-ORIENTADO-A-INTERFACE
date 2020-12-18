using Domain.Interface.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceProducts
{
    public interface IProduct : IGeneric<Product>
    {
        Task<List<Product>> ListarProdutosUsuario(string userId);

        Task<List<Product>> ListarProdutos (Expression<Func<Product,bool>> exProduto);

        Task<Product> GetProduto(int produtoId);

        Task<List<Product>> ListarProdutosCarrinhoUsuario(string userId);

    }
}
