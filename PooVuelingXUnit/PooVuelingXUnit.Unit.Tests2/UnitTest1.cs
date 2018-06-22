using NMock;
using System;
using Xunit;

namespace PooVuelingXUnit.Unit.Tests2{
    public class CalculadoraXUnitTests{
        private MockFactory factory;
        private Mock<ICalculadora> mock;
        private ICalculadora MockObject;

        public CalculadoraXUnitTests(){
            factory = new MockFactory();
            mock = factory.CreateMock<ICalculadora>();

            mock.Expects.One.MethodWith(x => x.Suma(2, 2)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Resta(6, 2)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Division(24, 6)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Multiplicacion(3, 2)).WillReturn(6);
            
            MockObject = mock.MockObject;
        }

        [Fact]
        public void SumaTestXUnit() {
            Assert.Equal(4, MockObject.Suma(2, 2));
        }

        [Fact]
        public void RestaTestXUnit() {
            Assert.Equal(4, MockObject.Resta(6, 2));
        }

        [Fact]
        public void DivisionTestXUnit() {
            Assert.Equal(4, MockObject.Division(24, 6));
        }

        [Fact]
        public void MultiplicacionTestXUnit() {
            Assert.Equal(6, MockObject.Multiplicacion(3, 2));
        }
    }
}
