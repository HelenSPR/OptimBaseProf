using Atechnology.winDraw.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fo_library.Export.OptimizationExporters
{
    internal interface IBeamStore<Item>
    {
        CartCell<Item> GetCartCell(SawBeam sawBeam);

        void FillStore(IEnumerable<SawBeam> sawBeams);
    }
}
