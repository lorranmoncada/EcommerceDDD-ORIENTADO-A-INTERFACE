using Domain.Interface.InterfaceProducts;
using Domain.Interface.InterfaceServices;
using Domain.Services;
using Entities.Entities;
using Infraestructure.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTesEcommerce
{
    
        [TestClass]
        public class UnitTestEcomerce
        {
            [TestMethod]
            public async Task AddProductComSucesso()
            {
                try
                {
                    IProduct _IProduct = new RepositoryProduct();
                    IServiceProduct _IServiceProduct = new ServiceProduct(_IProduct);
                    var produto = new Product
                    {
                        Descricao = string.Concat("Descrição Test TDD", DateTime.Now.ToString()),
                        QtdEstoque = 10,
                        Nome = string.Concat("Nome Test TDD", DateTime.Now.ToString()),
                        Valor = 20,
                        UserId = "31de73f0-80c8-4cfb-98be-6129a9c57402"
                    };
                    await _IServiceProduct.AddProduct(produto);

                    Assert.IsFalse(produto.LstNotifies.Any());
                }
                catch (Exception)
                {

                    Assert.Fail();
                }
            }

            [TestMethod]
            public async Task AddProductComValidacaoCampoObrigatorio()
            {
                try
                {
                    IProduct _IProduct = new RepositoryProduct();
                    IServiceProduct _IServiceProduct = new ServiceProduct(_IProduct);
                    var produto = new Product
                    {

                    };
                    await _IServiceProduct.AddProduct(produto);

                    Assert.IsTrue(produto.LstNotifies.Any());
                }
                catch (Exception)
                {

                    Assert.Fail();
                }
            }

            [TestMethod]
            public async Task ListarProdutosUsuario()
            {

                try
                {
                    IProduct _IProduct = new RepositoryProduct();

                    var listaProdutos = await _IProduct.ListarProdutosUsuario("31de73f0-80c8-4cfb-98be-6129a9c57402");

                    Assert.IsTrue(listaProdutos.Any());
                }
                catch (Exception)
                {

                    Assert.Fail();
                }
            }

            [TestMethod]
            public async Task GetEntityById()
            {
                try
                {
                    IProduct _IProduct = new RepositoryProduct();
                    var listaProdutos = await _IProduct.ListarProdutosUsuario("31de73f0-80c8-4cfb-98be-6129a9c57402");
                    var produto = await _IProduct.GetEntityById(listaProdutos.LastOrDefault().Id);

                    Assert.IsTrue(produto != null);
                }
                catch (Exception)
                {

                    Assert.Fail();
                }
            }

            [TestMethod]
            public async Task Delete()
            {
                try
                {
                    IProduct _IProduct = new RepositoryProduct();
                    var listaProdutos = await _IProduct.ListarProdutosUsuario("31de73f0-80c8-4cfb-98be-6129a9c57402");
                    var ultimoProduto = listaProdutos.LastOrDefault();
                    await _IProduct.Delete(ultimoProduto);
                    Assert.IsTrue(true);
                }
                catch (Exception)
                {
                    Assert.Fail();
                }
            }


        }
    }

