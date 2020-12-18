using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Entities.Entities;
using Entities.Entities.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebEComerce.Models;

namespace WebEComerce.Controllers
{
    public class CompraUsuarioController : HelpQrCode
    {
        public readonly InterfaceCompraUsuarioApp _InterfaceCompraUsuarioApp;
        public readonly UserManager<ApplicationUser> _UserManager;
        IWebHostEnvironment _Environment;

        public CompraUsuarioController(UserManager<ApplicationUser> UserManager, InterfaceCompraUsuarioApp InterfaceCompraUsuarioApp, IWebHostEnvironment environment)
        {
            _UserManager = UserManager;
            _InterfaceCompraUsuarioApp = InterfaceCompraUsuarioApp;
            _Environment = environment;
        }

        [HttpPost("/api/AdicionarProdutoCarrinho")]
        public async Task<JsonResult> AdicionarProdutoCarrinho(string id, string nome, string qtd)
        {
            var userLogado = await _UserManager.GetUserAsync(User);

            if (userLogado != null)
            {
                await _InterfaceCompraUsuarioApp.AdicionarProdutoCarrinho(userLogado.Id, new CompraUsuario()
                {
                    IdProduto = Convert.ToInt32(id),
                    QtdCompra = Convert.ToInt32(qtd),
                    Estado = EnumEstadoCompra.Produto_Carrinho,
                    UserId = userLogado.Id
                });

                return Json(new { sucesso = true });
            }

            return Json(new { sucesso = false });
        }

        public async Task<IActionResult> Imprimir(int id)
        {
            var userLogado = await _UserManager.GetUserAsync(User);
            var compraUsuario = await _InterfaceCompraUsuarioApp.ProdutosComprados(userLogado.Id, id);

            return await Download(compraUsuario, _Environment);
        }
        public async Task<IActionResult> ConfirmaCompra()
        {
            var usuario = await _UserManager.GetUserAsync(User);

            var sucesso = await _InterfaceCompraUsuarioApp.ConfirmaCompraCarrinhoUsuario(usuario.Id);

            if (sucesso)
            {
                return RedirectToAction("MinhasCompras", new { mensagem = true });
            }
            else
                return RedirectToAction("FinalizarCompra");
        }
        public async Task<IActionResult> FinalizarCompra()
        {
            var usuario = await _UserManager.GetUserAsync(User);
            var compraUsuario = await _InterfaceCompraUsuarioApp.CarrinhoCompras(usuario.Id);
            return View(compraUsuario);
        }

       public async Task<IActionResult> MinhasCompras(bool mensagem = false)
        {
            var usuario = await _UserManager.GetUserAsync(User);
            var compraUsuario = await _InterfaceCompraUsuarioApp.MinhasCompras(usuario.Id);

            if (mensagem)
            {
                ViewBag.Sucesso = true;
                ViewBag.Mensagem = "Compra efetivada com sucesso. Pague o boleto para garantir sua compra!";
            }

            return View(compraUsuario);
        }

        [HttpPost("/api/GetAllCompraUsuario")]
        public async Task<JsonResult> GetAllCompraUsuario()
        {
            var userLogado = await _UserManager.GetUserAsync(User);

            if (userLogado != null)
            {
                return Json(await _InterfaceCompraUsuarioApp.GetListCompraUsuario(userLogado.Id));
            }

            return Json(new { sucesso = false });
        }
    }
}
