using Calculator.Contracts;
using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Integration.Tests
{
    public class CalculadoraIntegrationTests {
        ICalculadora iCalculadora = new Calculadora();

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 6)]
        public void SumaTestXUnit(int num1, int num2, int result) {
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
