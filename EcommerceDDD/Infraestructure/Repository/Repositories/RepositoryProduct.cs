using Domain.Interface.InterfaceProducts;
using Entities.Entities;
using Entities.Entities.Enums;
using Infraestructure.Configuration;
using Infraestructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Product>, IProduct
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryProduct()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<List<Product>> ListarProdutosCarrinhoUsuario(string userId)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                var produtoCarrinhoUsuario = await (from p in data.Product
                                                    join c in data.CompraUsuario on p.Id equals c.IdProduto
                                                    join co in data.Compra on c.IdCompra equals co.Id
                                                    where c.UserId == userId && c.Estado == EnumEstadoCompra.Produto_Carrinho
                                                    select new Product
                                                    {
                                                        Id = p.Id,
                                                        Nome = p.Nome,
                                                        Descricao = p.Descricao,
                                                        Observacao = p.Observacao,
                                                        Valor = p.Valor,
                                                        QtdCompra = c.QtdCompra,
                                                        IdProdutoCarrinho = c.Id,
                                                        QtdEstoque = p.QtdEstoque,
                                                        Url = p.Url,
                                                        DataCompra = co.DataCompra
                                                    }).AsNoTracking().ToListAsync();

                return produtoCarrinhoUsuario;


            }
        }

        public async Task<Product> GetProduto(int produtoIdCarrinho)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                var produtoCarrinhoUsuario = await(from p in data.Product
                                                   join c in data.CompraUsuario on p.Id equals c.IdProduto
                                                   where c.Id == produtoIdCarrinho && c.Estado == EnumEstadoCompra.Produto_Carrinho
                                                   select new Product
                                                   {
                                                       Id = p.Id,
                                                       Nome = p.Nome,
                                                       Descricao = p.Descricao,
                                                       Observacao = p.Observacao,
                                                       Valor = p.Valor,
                                                       QtdCompra = c.QtdCompra,
                                                       IdProdutoCarrinho = c.Id,
                                                       QtdEstoque = p.QtdEstoque,
                                                       Url = p.Url
                                                   }).AsNoTracking().FirstOrDefaultAsync();

                return produtoCarrinhoUsuario;
            }
        }


        public async Task<List<Product>> ListarProdutos(Expression<Func<Product, bool>> exProduto)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                return await data.Product.Where(exProduto).AsNoTracking().ToListAsync();
            }
        }

        public async Task<List<Product>> ListarProdutosUsuario(string userId)
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                //EXECUTA SELECT ONDE SO TRAZ OS PRODUTOS COM O ID DO USUARIO LOGADO
                return await data.Product.Where(p => p.UserId == userId).AsNoTracking().ToListAsync();
            }
        }


    }
}
