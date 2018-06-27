using NMock;
using System;
using System.Collections.Generic;
using System.Text;

namespace PooVuelingXUnit.Unit.Tests2
{
    public class CalculadoraFixture{
        private MockFactory _factory = new MockFactory();
        

        public CalculadoraFixture() {
            var mock = _factory.CreateMock<ICalculadora>();
            mock.Expects.One.MethodWith(x => x.Suma(2, 2)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Resta(6, 2)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Division(24, 6)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Multiplicacion(3, 2)).WillReturn(6);

            MockObject = mock.MockObject;
        }
        public ICalculadora MockObject { get; private set; }
    }
}
