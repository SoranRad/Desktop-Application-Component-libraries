using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control.Controls;

namespace MS_Control.Filter_Manage
{
    public partial class Form_Select_Column : MS_Mother_Two
    {
        public bool Is_Type_Numeric(TypeCode Col_Type)
        {
            switch (Col_Type)
            {
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Single:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
                default:
                    return false;
            }
        }

        public List<GridEXColumn> MS_Get_Select_List
        {
            get 
            { 
                return mS_GridX1
                       .GetCheckedRows()
                       .Select(x => x.DataRow as GridEXColumn)
                       .ToList(); 
            }
        } 
        public Form_Select_Column(MS_GridX _Grid)
        {
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(178)));
            InitializeComponent();

            mS_GridX1.DataSource = _Grid
                .RootTable
                .Columns
                .OfType<GridEXColumn>()
                .Where(x => Is_Type_Numeric(x.DataTypeCode)
                            && x.Visible 
                            && x.ShowInFieldChooser)
                .ToList();
        }

        private void ms_save_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
        }
    }
}
