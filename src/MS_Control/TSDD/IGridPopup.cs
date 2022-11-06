using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MS_Control.TSDD
{

    public interface IGridPopup
    {

        event Row_Seleced  MS_On_Row_Selected;
        event EventHandler MS_On_BeNull;

        void Refresh_Grid();
        void Refresh_Grid(object Parameter);
        void Refresh_Grid(params object[] List_Columns);

        object MS_Get_Selected();
        void MS_Set_Select(object Item_to_Select);

        void Filter_Grid(string Str);

        Control MS_Get_Grid();
        void Set_Parent(MS_TextBox_ADC Parent);

        void Process_Key(Keys KeyCode);
        void Process_Mouse(MS_INPUT.WMessages Event, Point Coordinate);
        bool Has_Focus();
        void Reset_DB_Click();
    }

}
