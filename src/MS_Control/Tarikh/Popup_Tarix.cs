using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.Tarikh
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class Popup_Tarix : ToolStripDropDown
    {
        private Control _Grid;
        public ToolStripControlHost Host { get; set; }
        public Control MS_Grid_Control
        {
            get { return _Grid; }
        }

        #region متد
        public void Set_Control(Control Ctrl)
        {
            if (Ctrl == null)
            {
                Items.Clear();
                return;
            }

            Host = new ToolStripControlHost(Ctrl);
            Host.Margin = Padding.Empty;
            Host.Padding = Padding.Empty;
            Host.AutoSize = false;
            Host.AutoToolTip = false;
            _Grid = Ctrl;
            Ctrl.Location = Point.Empty;
            Host.Size = new Size(_Grid.Size.Width, _Grid.Size.Height);
            Items.Clear();
            Items.Add(Host);
            Ctrl.Parent = this;
        }
        #endregion
        public Popup_Tarix()
        {
            InitializeComponent();
            Capture = true;
            AutoSize = false;
            DropShadowEnabled = false;
            AutoClose = true;
            this.AutoSize = false;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
        
    }
}
