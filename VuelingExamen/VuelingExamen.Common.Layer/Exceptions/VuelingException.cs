using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VuelingExamen.Common.Layer;
using VuelingExamen.Common.Layer.ResourceCommonLayerFiles;

namespace Vueling.Common.Layer {
    public class VuelingException : Exception {
        public VuelingException() { }

        public VuelingException(string message) : base(message) { }

        public VuelingException(string message, Exception inner) : base(message, inner) { }

        public VuelingException(ArgumentException inner) : base(ResourceCommonLayer.ArgumentError, inner) { }

        public VuelingException(NotSupportedException inner) : base(ResourceCommonLayer.NotSuportedError, inner){  }

        public VuelingException(ObjectDisposedException inner) : base(ResourceCommonLayer.ObjectDisposedError, inner) { }

        public VuelingException(InvalidOperationException inner) : base(ResourceCommonLayer.InvalidOperationError, inner) { }

    }
}
