﻿using Desafio.TesteIntegracao.Context;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Desafio.TesteIntegracao.Apis
{
    public class ShowMeTheCodeTest
    {
        private readonly TestContext _testContext;
        public ShowMeTheCodeTest()
        {
            _testContext = new TestContext();
        }

        [Fact]
        public async Task TaxaJuros_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/shownethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
