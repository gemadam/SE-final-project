using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    public interface IFlatteningAlgorithm
    {
        void Execute();

        void Reverse();
    }
}
