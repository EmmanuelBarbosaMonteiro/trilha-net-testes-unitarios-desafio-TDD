using NewTalents;
using Xunit;

namespace TestsNewTalents
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora("21/10/2023");
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void Somar_DeveRetornarSomaCorreta(int val1, int val2, int resultadoEsperado)
        {
            // Act
            int resultado = _calculadora.Somar(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 5, 0)]
        public void Subtrair_DeveRetornarSubtracaoCorreta(int val1, int val2, int resultadoEsperado)
        {
            // Act
            int resultado = _calculadora.Subtrair(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(4, 5, 20)]
        public void Multiplicar_DeveRetornarMultiplicacaoCorreta(int val1, int val2, int resultadoEsperado)
        {
            // Act
            int resultado = _calculadora.Multiplicar(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(20, 5, 4)]
        public void Dividir_DeveRetornarDivisaoCorreta(int val1, int val2, int resultadoEsperado)
        {
            // Act
            int resultado = _calculadora.Dividir(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Dividir_PorZero_DeveLancarExcecao()
        {
            // Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(2, 0));
        }

        [Fact]
        public void Historico_DeveRetornarHistoricoCorreto()
        {
            // Arrange
            _calculadora.Somar(1, 2);
            _calculadora.Somar(3, 4);
            _calculadora.Somar(5, 6);

            // Act
            var lista = _calculadora.Historico();

            // Assert
            Assert.Equal(3, lista.Count);
            Assert.NotEmpty(lista);
        }
    }
}