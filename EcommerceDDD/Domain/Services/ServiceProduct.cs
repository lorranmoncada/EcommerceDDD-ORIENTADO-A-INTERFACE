using Domain.Interface.InterfaceProducts;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }
        public async Task AddProduct(Product product)
        {
            var validaNome = product.ValidaPropriedadeString(product.Nome, "Nome");

            var validaValor = product.ValidaPropriedadeDecimal(product.Valor, "Valor");

            var validaQuatEstoque = product.ValidaPropriedadeInt(product.QtdEstoque, "QtdEstoque");

            if (validaNome && validaValor && validaQuatEstoque)
            {
                product.DataCadastro = DateTime.Now;
                product.DataAlteracao = DateTime.Now;
                product.Estado = true;
                await _IProduct.Add(product);
            }
        }

        public async Task<List<Product>> ListarProdutosComEstoque(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                return await _IProduct.ListarProdutos(p => p.QtdEstoque > 0);
            else
                return await _IProduct.ListarProdutos(p => p.QtdEstoque > 0 &&
                p.Nome.ToUpper().Contains(descricao.ToUpper()));
        }

        public async Task UpdateProduct(Product product)
        {
            var validaNome = product.ValidaPropriedadeString(product.Nome, "Nome");

            var validaValor = product.ValidaPropriedadeDecimal(product.Valor, "Valor");

            var validaQuatEstoque = product.ValidaPropriedadeInt(product.QtdEstoque, "QtdEstoque");

            if (validaNome && validaValor && validaQuatEstoque)
            {
                product.DataAlteracao = DateTime.Now;
                await _IProduct.Update(product);
            }
        }
    }
}
