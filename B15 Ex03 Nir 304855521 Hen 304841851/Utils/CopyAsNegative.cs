using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace B15_Ex03_Nir_304855521_Hen_304841851.Utils
{
    public class CopyAsNegative : FilterBase
    {
        protected override Image filterSwap(Image io_Image)
        {
            return BitmapFilters.ExtBitmap.CopyAsNegative(io_Image);
        }
    }
}
