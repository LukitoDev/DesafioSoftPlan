using Desafio.Entidades;
using Xunit;

namespace Desafio.Teste.Entidades
{
    public class CalculaJurosTest
    {
        [Theory(DisplayName = "Calcular Juros")]
        [InlineData(100, 5)]
        public void CalcularJuros(double valorInicial, int meses)
        {
            var result = TaxaJuros.CalculaJuros(valorInicial, meses);

            Assert.IsType<double>(result);
        }
    }
}
