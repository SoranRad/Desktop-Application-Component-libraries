using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using BorderStyle = System.Windows.Forms.BorderStyle;

namespace MS_Control.Tarikh
{
    internal class Field_Ruz :FieldControl
    {
        #region فیلد
        
        #endregion
        #region پراپرتی

        #endregion
        #region متد

        #endregion

        public Field_Ruz()
        {
            base.RangeLower = 1;
            base.RangeUpper = 31;

            BorderStyle =BorderStyle.None;
            MaxLength = 2;
            TabStop = false;
        }
    }
}
