using System;
using Xunit;

namespace PooVuelingXUnit.Integration.Tests2{
    public class CalculadoraXUnitTests{
        ICalculadora iCalculadora = new Calculadora();

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        public void SumaTestXUnit(int num1, int num2, int result){
            Assert.Equal(result, iCalculadora.Suma(num1, num2));
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 6)]
        public void RestaTestXUnit(int num1, int num2, int result) {
            Assert.Equal(result, iCalculadora.Resta(num1, num2));
        }

        [Theory]
        [InlineData(8, 2, 4)]
        [InlineData(18, 3, 6)]
        public void DivisionTestXUnit(int num1, int num2, int result) {
            Assert.Equal(result, iCalculadora.Division(num1, num2));
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        public void MultiplicacionTestXUnit(int num1, int num2, int result) {
            Assert.Equal(result, iCalculadora.Multiplicacion(num1, num2));
        }
    }
}
