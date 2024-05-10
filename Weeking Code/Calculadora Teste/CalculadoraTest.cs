using System.Security.Cryptography.X509Certificates;
using Weeking_Code.Calculadora;

namespace Calculadora_Teste
{
    public class CalculadoraTeste
    {

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

        [Fact]
        public void Divisao_DeveThrowException()
        {
            //arrange
            var _obj = new Calculadora();
            var _valorA = 0;
            var _valorB = 2;

            //Assert
            Assert.ThrowsAny<DivideByZeroException>(()=>_obj.Dividir(_valorA, _valorB));
        }
    }
}