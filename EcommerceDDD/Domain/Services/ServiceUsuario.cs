using Domain.Interface.InterfaceServices;
using Domain.Interface.InterfaceUsuario;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IUsuario _IUsuario;

        public ServiceUsuario(IUsuario IUsuario)
        {
            _IUsuario = IUsuario;
        }
        public async Task<List<ApplicationUser>> ListarUsuarioSomenteParaAdm(string UserId)
        {
            var usuario = await _IUsuario.ObterUsuario(UserId);

            if (usuario.TipoUsuario == TipoUsuario.Administrador)
            {
                return await _IUsuario.List();
            }

            return new List<ApplicationUser>();
        }
    }
}
