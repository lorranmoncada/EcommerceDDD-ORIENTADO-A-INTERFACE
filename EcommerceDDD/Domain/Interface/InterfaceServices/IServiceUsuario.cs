using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices
{
   public interface IServiceUsuario
    {
        Task<List<ApplicationUser>> ListarUsuarioSomenteParaAdm(string UserId);
    }
}
