using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    public class FlatteningAlgorithmContext
    {
        public IFlatteningAlgorithm Algorithm { get; private set; }

        public FlatteningAlgorithmContext(IFlatteningAlgorithm flatteningAlgorithm)
        {
            Algorithm = flatteningAlgorithm;
        }

        public void SetAlgorithm(IFlatteningAlgorithm algorithm)
        {
            Algorithm = algorithm;
        }
    }
}
