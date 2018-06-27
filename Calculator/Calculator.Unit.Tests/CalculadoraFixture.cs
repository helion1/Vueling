using Calculator.Contracts;
using NMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Unit.Tests {
    public class CalculadoraFixture {
        private MockFactory _factory = new MockFactory();
        public ICalculadora MockObject { get; private set; }

        public CalculadoraFixture() {
            var mock = _factory.CreateMock<ICalculadora>();

            mock.Expects.One.MethodWith(x => x.Division(9, 3)).WillReturn(3);
            mock.Expects.One.MethodWith(x => x.Multiplicacion(3, 2)).WillReturn(6);
            mock.Expects.One.MethodWith(x => x.Resta(7, 3)).WillReturn(4);
            mock.Expects.One.MethodWith(x => x.Suma(2, 5)).WillReturn(7);

            MockObject = mock.MockObject;
        }
    }
}
