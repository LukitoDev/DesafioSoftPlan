using Desafio.TesteIntegracao.Context;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Desafio.TesteIntegracao.Apis
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
            var response = await _testContext.Client.GetAsync("/taxaJuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
