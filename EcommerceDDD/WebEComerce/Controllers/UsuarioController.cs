using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Entities.Entities;
using Entities.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Web_ECommerce.Controllers;

namespace WebEComerce.Controllers
{
    [Authorize]
    [LogActionFilter]
    public class UsuarioController : BaseController
    {
        public readonly InterfaceUsuarioApp _InterfaceUsuarioApp;

        public UsuarioController(InterfaceUsuarioApp InterfaceUsuarioApp, ILogger<UsuarioController> logger,
            InterfaceLogSistemaApp InterfaceLogSistemaApp, UserManager<ApplicationUser> UserManager)
        : base(logger, UserManager, InterfaceLogSistemaApp)
        {
            _InterfaceUsuarioApp = InterfaceUsuarioApp;
        }

        public async Task<IActionResult> ListarUsuarios()
        {
            return View(await _InterfaceUsuarioApp.ListarUsuarioSomenteParaAdm(await ReturnIdUsuarioLogado()));
        }

        // GET
        public async Task<IActionResult> Edit(string id)
        {
            var tipoUsuarios = new List<SelectListItem>();

            tipoUsuarios.Add(new SelectListItem { Text = Enum.GetName(typeof(TipoUsuario), TipoUsuario.Comum), Value = Convert.ToInt32(TipoUsuario.Comum).ToString() });
            tipoUsuarios.Add(new SelectListItem { Text = Enum.GetName(typeof(TipoUsuario), TipoUsuario.Administrador), Value = Convert.ToInt32(TipoUsuario.Administrador).ToString() });
            ViewBag.TipoUsuarios = tipoUsuarios;

            return View(await _InterfaceUsuarioApp.ObterUsuario(id));

        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ApplicationUser usuario)
        {
            try
            {
                await _InterfaceUsuarioApp.AtualizarTipoUsuario(usuario.Id, (TipoUsuario)usuario.TipoUsuario);

                await LogEcommerce(EnumTipoLog.Informativo, usuario);

                return RedirectToAction(nameof(ListarUsuarios));
            }
            catch (Exception erro)
            {
                await LogEcommerce(EnumTipoLog.Erro, erro);

                return View("Edit", usuario);
            }
        }
    }
}
