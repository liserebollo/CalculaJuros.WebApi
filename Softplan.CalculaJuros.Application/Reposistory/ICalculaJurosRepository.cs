using Softplan.CalculaJuros.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Application.Reposistory
{
    public interface ICalculaJurosRepository 
    {
        Task<TaxaDto> BuscaTaxa();
    }
}
