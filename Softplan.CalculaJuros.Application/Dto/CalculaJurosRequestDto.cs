using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Application.Dto
{
    public class CalculaJurosRequestDto
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }
    }
}
