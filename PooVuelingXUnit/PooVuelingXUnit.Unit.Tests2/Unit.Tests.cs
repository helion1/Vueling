using NMock;
using System;
using Xunit;

namespace PooVuelingXUnit.Unit.Tests2{
    public class CalculadoraXUnitTests : IClassFixture<CalculadoraFixture>{
        CalculadoraFixture fixture;

        public CalculadoraXUnitTests(CalculadoraFixture fixture){
            this.fixture = fixture;
        }
        
        [Fact]
        public void SumaTestXUnit() {
            Assert.Equal(4, fixture.MockObject.Suma(2, 2));
        }

        [Fact]
        
        public void RestaTestXUnit() {
            Assert.Equal(4, fixture.MockObject.Resta(6, 2));
        }

        [Fact]
        public void DivisionTestXUnit() {
            Assert.Equal(4, fixture.MockObject.Division(24, 6));
        }

        [Fact]
        public void MultiplicacionTestXUnit() {
            Assert.Equal(6, fixture.MockObject.Multiplicacion(3, 2));
        }
    }
}
