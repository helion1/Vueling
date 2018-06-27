using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Unit.Tests{
    public class CalculatorUnitTests : IClassFixture<CalculadoraFixture>{
        CalculadoraFixture fixture;

        public CalculatorUnitTests(CalculadoraFixture fixture) {
            this.fixture = fixture;
        }

        [Fact]
        public void DivisionTest() {
            Assert.Equal(3, fixture.MockObject.Division(9, 3));
        }

        [Fact]
        public void MultiplicacionTest() {
            Assert.Equal(6, fixture.MockObject.Multiplicacion(3, 2));
        }

        [Fact]
        public void RestaTest() {
            Assert.Equal(4, fixture.MockObject.Resta(7, 3));
        }

        [Fact]
        public void SumaTest() {
            Assert.Equal(7, fixture.MockObject.Suma(2, 5));
        }


    }
}
