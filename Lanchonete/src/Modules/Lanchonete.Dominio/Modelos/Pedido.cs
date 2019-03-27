using System;
using System.Collections.Generic;

namespace Lanchonete.Dominio.Modelos
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public ICollection<Lanche> Lanches { get; set; }
        public decimal Total { get; set; }
    }
}
