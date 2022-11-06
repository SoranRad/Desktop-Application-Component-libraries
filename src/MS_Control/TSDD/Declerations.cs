using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Control.TSDD
{
    public class On_Item_Selected : EventArgs
    {
        public int Index_Row { get; set; }
        public object Data_Row { get; set; }
        public bool Is_OK { get; set; }
    }
    public delegate void Row_Seleced(On_Item_Selected e);

    public class On_Selected : EventArgs
    {
        public object Item { get; set; }
        public int Index { get; set; }
    }

    public enum SizeMode
    {
        Combo_Size,
        Control_Size,
        Mixed_Size,
        Custome_Size,
    }
    public enum KindShow
    {
        Right,
        Middle,
        Left,
    }
}
