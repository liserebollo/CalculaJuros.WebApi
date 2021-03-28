using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Application.Dto
{
    public class URLDto
    {

        private string urlApiTaxa;
        private string urlApiCalculo;

        public string UrlApiTaxa
        {
            get { return urlApiTaxa; }
            set { urlApiTaxa = value; }
        }

        public string UrlApiCalculo
        {
            get { return urlApiCalculo; }
            set { urlApiCalculo = value; }
        }

        public URLDto()
        {
            this.urlApiTaxa = "https://github.com/liserebollo/Taxa.WebApi";
            this.urlApiCalculo = "https://github.com/liserebollo/CalculaJuros.WebApi";

        }
    }
}    
