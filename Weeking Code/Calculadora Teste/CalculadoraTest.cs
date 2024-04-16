using Weeking_Code.Calculadora;

namespace Calculadora_Teste
{
    public class CalculadoraTeste
    {

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(10,15,25)]
        public void Somar_DeveRealizarSomaValida(int valorA, int valorB, int expected)
        {
            //Arrange
            var _obj = new Calculadora();


            //Act
            var _ret = _obj.Somar(valorA, valorB);

            //Assert
            Assert.Equal(1, _ret);
        }

        [Fact]
        public void Multiplicar_DeveRealizarMultiplicacaoValida()
        {
            //Arrange
            var _obj = new Calculadora();

            //Act
            var _result = _obj.Multiplicar(1, 1);

            //Assert
            Assert.Equal(2, _result);
        }

        [Fact]
        public void Somar_DeveRealizarSomaInvalida()
        {

            //Arrange
            var _obj = new Calculadora();
            var _valorA = 1;
            var _valorB = 2;

            //Act
            var _ret = _obj.Somar(_valorA, _valorB);

            //Assert
            Assert.NotEqual(3, _ret);
        }
    }
}