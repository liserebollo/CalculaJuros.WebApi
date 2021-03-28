using Newtonsoft.Json;
using Softplan.CalculaJuros.Application.Dto;
using Softplan.CalculaJuros.Application.Reposistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Infrastructure.Reposistory
{
    public class CalculaJurosRepository : ICalculaJurosRepository
    {
        public async Task<TaxaDto> BuscaTaxa()
        {
            TaxaDto result;
            try
            {
                HttpResponseMessage response;

                using (HttpClient client = new HttpClient())
                {
                    response = await client.GetAsync("https://localhost:44335/Taxa/taxaJuros");

                }

                result = JsonConvert.DeserializeObject<TaxaDto>(response.Content.ReadAsStringAsync().Result);

            }
            catch (Exception)
            {

                throw;
            }

            return result;
}   }   }
