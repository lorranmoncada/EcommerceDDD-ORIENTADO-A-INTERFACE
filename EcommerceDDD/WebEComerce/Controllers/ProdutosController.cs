using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading.Tasks;
using Application.Interface;
using Entities.Entities;
using Entities.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_ECommerce.Controllers;

namespace WebEComerce.Controllers
{
    [Authorize]
    [LogActionFilter]
    public class ProdutosController : BaseController
    {
        public readonly InterfaceProductApp _InterfaceProductApp;

        public readonly InterfaceCompraUsuarioApp _InterfaceCompraUsuarioApp;

        private readonly IWebHostEnvironment _Enviroment;
        public ProdutosController(InterfaceProductApp InterfaceProductApp, ILogger<ProdutosController> logger,
            InterfaceLogSistemaApp InterfaceLogSistemaApp, UserManager<ApplicationUser> UserManager,
            InterfaceCompraUsuarioApp InterfaceCompraUsuarioApp, IWebHostEnvironment Enviroment)
        :base(logger, UserManager, InterfaceLogSistemaApp)
        {
            _InterfaceProductApp = InterfaceProductApp;
            _InterfaceCompraUsuarioApp = InterfaceCompraUsuarioApp;
            _Enviroment = Enviroment;
        }

        // GET: ProdutosController
        public async Task<IActionResult> Index()
        {
            var idUsuario = await ReturnIdUsuarioLogado();

            return View(await _InterfaceProductApp.ListarProdutosUsuario(idUsuario));
        }

        // GET: ProdutosController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _InterfaceProductApp.GetEntityById(id));
        }

        // GET: ProdutosController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ProdutosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product produto)
        {
            try
            {
                var idUsuario = await ReturnIdUsuarioLogado();
                produto.UserId = idUsuario;

                await _InterfaceProductApp.AddProduct(produto);

                if (produto.LstNotifies.Any())
                {
                    foreach (var item in produto.LstNotifies)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }

                    return View("Create", produto);
                }

                await SalvarImagemProduto(produto);
                await LogEcommerce(EnumTipoLog.Informativo, produto);
            }
            catch(Exception error)
            {
                await LogEcommerce(EnumTipoLog.Erro, error);
                return View("Create", produto); 
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProdutosController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _InterfaceProductApp.GetEntityById(id));
        }

        // POST: ProdutosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product produto)
        {
            try
            {
                await _InterfaceProductApp.UpdateProduct(produto);

                if (produto.LstNotifies.Any())
                {
                    foreach (var item in produto.LstNotifies)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }

                    return View("Edit", produto);
                }
            }
            catch
            {
                return View("Edit", produto);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: ProdutosController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _InterfaceProductApp.GetEntityById(id));
        }

        // POST: ProdutosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Product produto)
        {
            try
            {
                var produtoDelete = await _InterfaceProductApp.GetEntityById(id);
                await _InterfaceProductApp.Delete(produtoDelete);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> RemoverCarrinho(int id)
        {
            return View(await _InterfaceProductApp.GetProduto(id));
        }

        // POST: ProdutosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoverCarrinho(int id, Product produto)
        {
            try
            {
                var produtoDelete = await _InterfaceCompraUsuarioApp.GetEntityById(id);
                await _InterfaceCompraUsuarioApp.Delete(produtoDelete);

                return RedirectToAction(nameof(ListarProdutosCarrinhoUsuario));
            }
            catch
            {
                return View();
            }
        }

        [AllowAnonymous]
        //JsoinRsult RETONA UM JSON PARA A PAGINA
        [HttpGet("/api/ListarProdutosComEstoque")]
        public async Task<JsonResult> ListarProdutosComEstoque(string descricao)
        {
            return Json(await _InterfaceProductApp.ListarProdutosComEstoque(descricao));
        }

        //JsoinRsult RETONA UM JSON PARA A PAGINA
        [HttpGet("/api/ListarProdutosCarrinhoUsuario")]
        public async Task<IActionResult> ListarProdutosCarrinhoUsuario()
        {
            try
            {
                var idUsuario = await ReturnIdUsuarioLogado();

                return View(await _InterfaceProductApp.ListarProdutosCarrinhoUsuario(idUsuario));
            }
            catch
            {
                return BadRequest();
            }

        }

        public async Task SalvarImagemProduto(Product produtoTela)
        {

            try
            {
                var produto = await _InterfaceProductApp.GetEntityById(produtoTela.Id);

                if (produtoTela.Imagem != null)
                {
                    var webRoot = _Enviroment.WebRootPath;
                    var permissionSet = new PermissionSet(PermissionState.Unrestricted);
                    var writePermission = new FileIOPermission(FileIOPermissionAccess.Append, string.Concat(webRoot, "/imgProdutos"));
                    permissionSet.AddPermission(writePermission);

                    var Extension = System.IO.Path.GetExtension(produtoTela.Imagem.FileName);

                    var NomeArquivo = string.Concat(produto.Id.ToString(), Extension);

                    var diretorioArquivoSalvar = string.Concat(webRoot, "\\imgProdutos\\", NomeArquivo);

                    produtoTela.Imagem.CopyTo(new FileStream(diretorioArquivoSalvar, FileMode.Create));

                    produto.Url = string.Concat("https://localhost:44310/", "/imgProdutos/", NomeArquivo);

                    await _InterfaceProductApp.UpdateProduct(produto);
                }
            }
            catch (Exception error)
            {
                BadRequest(error);
            }

        }
    }
}
