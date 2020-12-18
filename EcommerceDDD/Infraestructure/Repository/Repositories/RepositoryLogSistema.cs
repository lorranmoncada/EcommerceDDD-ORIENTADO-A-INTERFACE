using Domain.Interface.InterfaceLogs;
using Entities.Entities;
using Infraestructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repository.Repositories
{
    public class RepositoryLogSistema: RepositoryGenerics<LogSistema>, ILogSistema
    {
    }
}
