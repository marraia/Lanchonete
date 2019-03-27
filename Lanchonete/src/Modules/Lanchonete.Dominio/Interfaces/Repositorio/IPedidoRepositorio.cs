using System.Threading.Tasks;
using Lanchonete.Dominio.Modelos;

namespace Lanchonete.Dominio.Interfaces.Repositorio
{
    public interface IPedidoRepositorio
    {
        Task InserirAsync(Pedido pedido);
    }
}
