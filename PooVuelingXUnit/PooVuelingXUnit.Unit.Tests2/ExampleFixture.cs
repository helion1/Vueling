using NMock;
using System;
using System.Collections.Generic;
using System.Text;

namespace PooVuelingXUnit.Unit.Tests2
{
    public sealed class ExampleFixture
    {
        public static ExampleFixture Current = new ExampleFixture();
        private MockFactory _factory;
        private Mock<ICalculadora> _mock;
        private ICalculadora MockObject;
        
        private ExampleFixture() {
            _factory = new MockFactory();
            _mock = _factory.CreateMock<ICalculadora>();
            _mock.Expects.One.Method(_ => _.Suma(2, 2)).WillReturn(4);
            _mock.Expects.One.Method(_ => _.Resta(6, 2)).WillReturn(4);
            _mock.Expects.One.Method(_ => _.Division(24, 6)).WillReturn(4);
            _mock.Expects.One.Method(_ => _.Multiplicacion(3, 2)).WillReturn(6);

            MockObject = _mock.MockObject;
        }

        ~ExampleFixture() {
            Dispose();
        }

        public void Dispose() {
            GC.SuppressFinalize(this);

            // Run at end
        }
    }
}
