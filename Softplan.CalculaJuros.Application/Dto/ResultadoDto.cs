using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Application.Dto
{
    
    public class ResultadoDto<T>
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

    }
}
    

