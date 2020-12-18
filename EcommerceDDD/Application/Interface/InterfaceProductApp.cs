using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface InterfaceProductApp : InterfaceGenericaApp<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task<List<Product>> ListarProdutosUsuario(string userId);
        Task<List<Product>> ListarProdutosComEstoque(string descricao);
        Task<Product> GetProduto(int produtoId);
        Task<List<Product>> ListarProdutosCarrinhoUsuario(string userId);

    }
}
