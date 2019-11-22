using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fotografia.Models
{
    public class AvaliacaoCliente
    {
        public AvaliacaoCliente()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Titlo { get; set; }
        public string NomeCliente { get; set; }
        public string ImagemCliente { get; set; }
        public string Comentario { get; set; }
        public int Avaliacao { get; set; }
    }
}
