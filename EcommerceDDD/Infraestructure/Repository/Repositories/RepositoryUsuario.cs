using Domain.Interface.InterfaceUsuario;
using Entities.Entities;
using Entities.Entities.Enums;
using Infraestructure.Configuration;
using Infraestructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Repositories
{
    public class RepositoryUsuario : RepositoryGenerics<ApplicationUser>, IUsuario
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryUsuario()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task AtualizarTipoUsuario(string UserId, TipoUsuario tipoUsuario)
        {
            using (var dado = new ContextBase(_OptionsBuilder))
            {

                var usuario = await dado.ApplicationUser.FirstOrDefaultAsync(u => u.Id.Equals(UserId));
                if (usuario != null)
                {
                    usuario.TipoUsuario = tipoUsuario;

                    dado.ApplicationUser.Update(usuario);
                    await dado.SaveChangesAsync();
                }

            }
        }

        public async Task<ApplicationUser> ObterUsuario(string userId)
        {
            using (var dado = new ContextBase(_OptionsBuilder))
            {
                return await dado.ApplicationUser.FirstOrDefaultAsync(u => u.Id.Equals(userId));
            }
        }
    }

}