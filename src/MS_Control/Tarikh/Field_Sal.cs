using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Control.Tarikh
{
    internal class Field_Sal :FieldControl
    {
        public Field_Sal()
        {
            base.RangeLower = 93;
            base.RangeUpper = 99;
        }
        public Field_Sal(byte Max,byte Min)
        {
            base.RangeLower = Min;
            base.RangeUpper = Max;
        }
    }
}
