using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace MS_Control.TSDD
{
    public partial class MS_Base_GridPopup : UserControl,IGridPopup
    {
        protected MS_TextBox_ADC    _Parent;
        protected object            _Selected_Item;
        private bool                Is_First_DBClick = true,_Scrolled=false;
        

        public MS_Base_GridPopup()
        {
            InitializeComponent();
            ms_grid.FilterMode=FilterMode.None;
            
        }

        public event EventHandler MS_On_BeNull;
        public event Row_Seleced  MS_On_Row_Selected;

        public virtual void     Filter_Grid (string Str)
        {
            
        }
        public virtual Control          MS_Get_Grid ()
        {
            return ms_grid;
        }

        public virtual object   MS_Get_Selected()
        {
            return _Selected_Item;
        }
        public virtual void     MS_Set_Select(object Item_to_Select)
        {
            
        }

        public virtual void Refresh_Grid    ()
        {
        }
        public virtual void Refresh_Grid    (params object[] List_Columns)
        {
        }
        public virtual void Refresh_Grid    (object Parameter)
        {
        }
        public virtual void SetFIlterList   (params object[] Parametters)
        {
            
        }
        public virtual void Set_Parent      (MS_TextBox_ADC Parent)
        {
            _Parent = Parent;
        }
        public void Reset_DB_Click          ()
        {
            //Is_First_DBClick = true;
            //_Scrolled = false;
        }
        //----====================================
        private void ms_Add_Click       (object sender, EventArgs e)
        {
           
        }
        private void ms_null_Click      (object sender, EventArgs e)
        {
            MS_On_BeNull?.Invoke(null,null);
        }

        private void ms_filter_Click    (object sender, EventArgs e)
        {
            ms_grid.FilterMode=FilterMode.Automatic;
            ms_grid.RootTable.Columns.OfType<GridEXColumn>()
                .MSZ_ForEach(x =>
                {
                    x.FilterEditType=FilterEditType.TextBox;
                });
            ms_grid.Refresh();
        }
        private void ms_select_Click    (object sender, EventArgs e)
        {
            if(ms_grid.CurrentRow==null || ms_grid.CurrentRow.RowType!=RowType.Record)
                return;

            MS_On_Row_Selected?.Invoke(new On_Item_Selected()
            { Data_Row = ms_grid.CurrentRow,
                Index_Row = ms_grid.CurrentRow.RowIndex,
                    Is_OK = true });
        }

        public void Process_Key         (Keys KeyCode)
        {
            switch (KeyCode)
            {
                    case Keys.Down:
                    MS_INPUT.SendMessage((int)ms_grid.Handle, 
                                            (int)MS_INPUT.WMessages.WM_KEYDOWN,
                                                (int)MS_INPUT.VKeys.VK_DOWN, 0);

                    break;
                    case Keys.Up:
                    MS_INPUT.SendMessage((int)ms_grid.Handle,
                                            (int)MS_INPUT.WMessages.WM_KEYDOWN,
                                                (int)MS_INPUT.VKeys.VK_UP, 0);
                    break;
                    case Keys.PageUp:
                    MS_INPUT.SendMessage((int)ms_grid.Handle,
                                            (int)MS_INPUT.WMessages.WM_KEYDOWN,
                                                (int)MS_INPUT.VKeys.VK_PRIOR, 0);
                    break;
                    case Keys.PageDown:
                    MS_INPUT.SendMessage((int)ms_grid.Handle,
                                            (int)MS_INPUT.WMessages.WM_KEYDOWN,
                                                (int)MS_INPUT.VKeys.VK_NEXT, 0);
                    break;
                    case Keys.Enter:
                    ms_select.PerformClick();
                    break;
            }
        }
        public bool Has_Focus           ()
        {
            if (_Scrolled)
                return true;
            if (ms_grid.Focused)
                return true;
            if (mS_Tool_Strip1.Focused)
                return true;
            foreach (ToolStripItem item in mS_Tool_Strip1.Items)
                if (item.Selected || item.Pressed)
                     return true;
            return false;
        }
        public void Process_Mouse       (MS_INPUT.WMessages Event, Point Coordinate)
        {
            foreach (Control Item in this.Controls)
            {
                var rec = Item.RectangleToScreen(Item.ClientRectangle);
                var R = rec.Contains(Coordinate);
                if (R && this.Controls.GetChildIndex(Item) == 0)
                {

                    if (Event == MS_INPUT.WMessages.WM_LBUTTONDOWN)
                    {
                        Coordinate = Item.PointToClient(Cursor.Position);

                        MS_INPUT.SendMessage(Item.Handle, (int) MS_INPUT.WMessages.WM_LBUTTONDOWN, (IntPtr) 0,
                            MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));



                        MS_INPUT.SendMessage(Item.Handle, (int) MS_INPUT.WMessages.WM_LBUTTONUP, (IntPtr) 0,
                            MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));
                    }
                    else
                    {
                        Coordinate = Item.PointToClient(Cursor.Position);

                        MS_INPUT.SendMessage(Item.Handle, (int)MS_INPUT.WMessages.WM_NCLBUTTONDBLCLK, (IntPtr)0,
                            MS_INPUT.MakeLParam(Coordinate.X, Coordinate.Y));
                    }
                    break;
                }

            }
        }
        
        private void ms_grid_RowDoubleClick(object sender, RowActionEventArgs e)
        {
           
            ms_select.PerformClick();

        }
        private void ms_grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
                ms_select.PerformClick();
        }
        private void ms_grid_Scroll(object sender, EventArgs e)
        {
            _Scrolled = true;
        }

    }
}
