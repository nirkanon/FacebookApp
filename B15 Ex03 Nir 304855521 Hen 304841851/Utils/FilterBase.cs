using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace B15_Ex03_Nir_304855521_Hen_304841851.Utils
{
    public abstract class FilterBase
    {
        public Image FilterImage(Image i_OriginalImage)
        {
            return filterSwap(i_OriginalImage);
        }

        protected abstract Image filterSwap(Image io_Image);
    }
}
