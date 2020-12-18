using Domain.Interface.Generics;
using Entities.Entities;
using Entities.Entities.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceProducts
{
    public interface ICompraUsuario: IGeneric<CompraUsuario>
    {
        public Task<List<CompraUsuario>> GetListCompraUsuario(string idUser);

        public Task<CompraUsuario> ProdutosCompradosPorEstado(string userId, EnumEstadoCompra estado, int? id = null);

        public Task<List<CompraUsuario>> MinhasCompradosPorEstado(string userId, EnumEstadoCompra estado);

        public Task<bool> ConfirmaCompraCarrinhoUsuario(string userId);
    }
}
