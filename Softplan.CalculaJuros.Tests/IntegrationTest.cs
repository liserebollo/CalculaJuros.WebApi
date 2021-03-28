using Microsoft.Extensions.DependencyInjection;
using Softplan.CalculaJuros.Application.Cases;
using Softplan.CalculaJuros.Application.Reposistory;
using Softplan.CalculaJuros.Infrastructure.Reposistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculaJuros.Tests
{
    public class IntegrationTest
    {
        public IntegrationTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICalculaJurosRepository, CalculaJurosRepository>();
            serviceCollection.AddTransient<ICalculaJurosRepository, CalculaJurosRepository>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
        public ServiceProvider ServiceProvider { get; private set; }
    }
}

