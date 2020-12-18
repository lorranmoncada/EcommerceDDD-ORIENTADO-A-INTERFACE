using Domain.Interface.Generics;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceUsuario
{
    public interface IUsuario: IGeneric<ApplicationUser>
    {
        Task<ApplicationUser> ObterUsuario(string userId);

        Task AtualizarTipoUsuario(string UserId, TipoUsuario tipoUsuario);
    }
}
