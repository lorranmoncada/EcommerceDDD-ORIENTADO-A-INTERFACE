using Domain.Interface.Generics;
using Entities.Entities;
using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceProducts
{
    public interface ICompra: IGeneric<Compra>
    {
        public Task<Compra> CompraPorEstado(string userId, EnumEstadoCompra estado);
    }
}
