using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Desafio.TesteIntegracao.Fixtures;
using Xunit;

namespace Desafio.TesteIntegracao.Scenarios
{
    public class TaxaJurosTest
    {
        private readonly TestContext _testContext;
        public TaxaJurosTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task TaxaJuros_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/TaxaJuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TaxaJuros_GetById_ValuesReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/calculaJuros/100/5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
