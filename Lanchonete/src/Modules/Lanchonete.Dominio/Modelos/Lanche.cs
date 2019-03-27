using System;
using System.Collections.Generic;

namespace Lanchonete.Dominio.Modelos
{
    public class Lanche
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
