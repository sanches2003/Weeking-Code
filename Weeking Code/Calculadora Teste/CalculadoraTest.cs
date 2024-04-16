using Weeking_Code.Calculadora;

namespace Calculadora_Teste
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar_DeveRealizarSomaValida()
        {
            //Arrange
            var _obj = new Calculadora();

            //Act
            var _ret = _obj.Somar(1, 1);

            //Assert
            Assert.Equal(1, _ret);
        }
        [Fact]
        public void Multiplicar_DeveRealizarMultiplicacaoValida()
        {
            //Arrange


            //Act


            //Assert
        }
    }
}