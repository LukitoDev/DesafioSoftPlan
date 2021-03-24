using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using System.IO;
using Desafio.TesteIntegracao.Context;

namespace Desafio.TesteIntegracao.Apis
{
    public class CalculaJurosTest
    {
        private readonly TestContext _testContext;
        public CalculaJurosTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task CalculaJuros_ValuesReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("calculajuros?valorinicial=100&meses=5");

            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
