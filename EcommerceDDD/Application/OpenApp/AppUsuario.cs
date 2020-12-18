using Application.Interface;
using Domain.Interface.InterfaceServices;
using Domain.Interface.InterfaceUsuario;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class AppUsuario : InterfaceUsuarioApp
    {
        private readonly IUsuario _IUsuario;
        private readonly IServiceUsuario _IServiceUsuario;
        public AppUsuario(IUsuario IUsuario, IServiceUsuario IServiceUsuario)
        {
            _IUsuario = IUsuario;
            _IServiceUsuario = IServiceUsuario;
        }
        public async Task AtualizarTipoUsuario(string UserId, TipoUsuario tipoUsuario)
        {
            await _IUsuario.AtualizarTipoUsuario(UserId, tipoUsuario);
        }

        public async Task<ApplicationUser> ObterUsuario(string userId)
        {
           return await _IUsuario.ObterUsuario(userId);
        }

        public async Task Add(ApplicationUser usuario)
        {
            await _IUsuario.Add(usuario);
        }

        public async Task Delete(ApplicationUser usuario)
        {
            await _IUsuario.Delete(usuario);
        }

        public async Task<ApplicationUser> GetEntityById(int id)
        {
            return await _IUsuario.GetEntityById(id);
        }

        public async Task<List<ApplicationUser>> List()
        {
            return await _IUsuario.List();
        }

        public async Task Update(ApplicationUser usuario)
        {
            await _IUsuario.Update(usuario);
        }

        public async Task<List<ApplicationUser>> ListarUsuarioSomenteParaAdm(string UserId)
        {
            return await _IServiceUsuario.ListarUsuarioSomenteParaAdm(UserId);
        }
    }
}
