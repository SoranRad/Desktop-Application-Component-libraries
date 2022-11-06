using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Control.Tarikh
{
    internal class Field_Mah : FieldControl
    {
        public Field_Mah()
        {
            base.RangeLower = 1;
            base.RangeUpper = 12;
        }
    }
}
