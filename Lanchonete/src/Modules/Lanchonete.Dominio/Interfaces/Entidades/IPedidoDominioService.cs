using System.Threading.Tasks;
using Lanchonete.Dominio.Modelos;

namespace Lanchonete.Dominio.Interfaces.Entidades
{
    public interface IPedidoDominioService
    {
        Task InserirAsync(Pedido pedido);
    }
}
