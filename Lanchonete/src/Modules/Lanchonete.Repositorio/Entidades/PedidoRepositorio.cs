using System;
using System.Threading.Tasks;
using Lanchonete.Dominio.Interfaces.Repositorio;
using Lanchonete.Dominio.Modelos;
using Lanchonete.Repositorio.Contexto;
using Microsoft.Extensions.Configuration;

namespace Lanchonete.Repositorio.Entidades
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private readonly LanchoneteContexto _contexto;

        public PedidoRepositorio(IConfiguration _configuracao)
        {
            var servidor = _configuracao.GetSection("ConnectionMongo").Value;
            var database = _configuracao.GetSection("DatabaseMongo").Value;

            _contexto = new LanchoneteContexto(servidor, database);
        }

        /// <summary>
        /// Insere um novo pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns></returns>
        public async Task InserirAsync(Pedido pedido)
        {
            await _contexto.Pedidos.InsertOneAsync(pedido);
        }
    }
}
