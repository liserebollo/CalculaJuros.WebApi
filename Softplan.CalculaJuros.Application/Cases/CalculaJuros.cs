using Softplan.CalculaJuros.Application.Dto;
using Softplan.CalculaJuros.Application.Reposistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Application.Cases
{
    public class CalculaJuros : ICalculaJuros
    {
        private readonly ICalculaJurosRepository _calculaJurosRepository;
        public CalculaJuros(ICalculaJurosRepository calculaJurosRepository)
        {
            _calculaJurosRepository = calculaJurosRepository;
        }


        public async Task<ResultadoDto<CalculaJurosResponseDto>> Execute(decimal valorInicial, int tempo)
        {
            var result = new ResultadoDto<CalculaJurosResponseDto>();
            result.Data = new CalculaJurosResponseDto();
            try
            {
                if (valorInicial <= 0 || tempo <= 0)
                {
                    //result.Data.ValorFinal = 0;
                    return result = new ResultadoDto<CalculaJurosResponseDto>
                    {
                        Sucess = false,
                        Message = "Valores permitidos menor ou igual a zero!",
                        Data = result.Data
                    };
                }

                var taxa = await _calculaJurosRepository.BuscaTaxa();

                var jurosComposto = Convert.ToDouble((1 + taxa.TaxaJuros));
                var resultJuros = Convert.ToDecimal(Math.Pow(jurosComposto, tempo)) * valorInicial;

                result.Data.ValorFinal = Math.Truncate(100 * resultJuros) / 100;
                result.Sucess = true;
                result.Message = "Sucesso!";

            }
            catch (Exception)
            {
                result = new ResultadoDto<CalculaJurosResponseDto>
                {
                    Sucess = false,
                    Message = "Não foi possível realizar o cálculo!"
                };

            }

            return result;
        }
    }
}
