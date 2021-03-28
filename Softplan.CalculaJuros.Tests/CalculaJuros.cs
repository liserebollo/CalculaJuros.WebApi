using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Softplan.CalculaJuros.Application.Cases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.CalculaJuros.Tests
{
    public class CalculaJuros : IClassFixture<IntegrationTest>
    {
        private readonly ICalculaJuros _calculaJuros;

        public CalculaJuros(IntegrationTest fixture)
        {
            _calculaJuros = fixture.ServiceProvider.GetRequiredService<ICalculaJuros>();
        }

        [NUnit.Framework.Theory]
        [InlineData(100, 5, true)]
        [InlineData(100, 10, true)]
        [InlineData(0, 0, false)]
        [InlineData(0, 5, false)]
        [InlineData(5, 0, false)]
        [InlineData(-1, 0, false)]
        [InlineData(-1, -2, false)]

        public void BuscandoTaxa(decimal valorInicial, int tempo, bool esperado)
        {
            var resultado = _calculaJuros.Execute(valorInicial, tempo).Result.Sucess;
            Assert.Equals(esperado, resultado);
        }
    }
}

