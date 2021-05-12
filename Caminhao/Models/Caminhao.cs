using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caminhao.Models
{
    public class Caminhao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public Int16 AnoFabricacao { get; set; }
        public Int16 AnoModelo { get; set; }

        public string Erro { get; set; }
    }
}
