using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
   public interface InterfaceUsuarioApp: InterfaceGenericaApp<ApplicationUser>
    {
        Task<ApplicationUser> ObterUsuario(string userId);

        Task AtualizarTipoUsuario(string UserId, TipoUsuario tipoUsuario);

        Task<List<ApplicationUser>> ListarUsuarioSomenteParaAdm(string UserId);
    }
}
