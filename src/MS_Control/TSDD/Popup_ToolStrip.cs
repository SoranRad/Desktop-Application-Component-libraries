using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Controls;

namespace MS_Control.TSDD
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class Popup_ToolStrip : ToolStripDropDown
    {
        private TableLayoutSettings tableSettings = null;
        private readonly int        rows = 5;
        private readonly int        columns = 5;
        private Size                tileSize = new Size(24, 24);
        #region فیلد
        private Control              _Grid;
        private Control              _Control;
        private int                 _StripSize = 25;
        public  ToolStripControlHost Host { get; set; }
        public  Control              MS_Grid_Control
        {
            get { return _Grid; }
        }
        
        #endregion
        #region متد
        public void Set_Control(Control Ctrl)
        {
            try
            {
                _Grid = Ctrl;
                _Control = Ctrl;
                if (Ctrl == null)
                {
                    Items.Clear();
                    return;
                }

                if (!(Ctrl is IGridPopup))
                    return;

                var pop = Ctrl as IGridPopup;

                _Grid = pop.MS_Get_Grid();

                Host = new ToolStripControlHost(_Grid)
                {

                    Margin = Padding.Empty,
                    Padding = Padding.Empty,
                    AutoSize = false,
                    AutoToolTip = false,
                    DoubleClickEnabled = true,
                };

                this.Padding = new Padding(0);
                this.Margin = new Padding(0);

                Host.Size = new Size(_Grid.Size.Width, _Grid.Size.Height);
                Ctrl.Anchor = AnchorStyles.Bottom
                              | AnchorStyles.Left
                              | AnchorStyles.Right
                              | AnchorStyles.Top;

                Items.Clear();
                Items.Add(Host);
            }
            catch (Exception)
            {
                
            }
            //InitializeTableLayoutSettings();

            //Ctrl.Parent = this;
            //Dock                = DockStyle.Fill,
            // Items.Add(new ToolStrip())
            //Ctrl.Location = Point.Empty;
            //Host.Anchor = AnchorStyles.Bottom
            //                    | AnchorStyles.Left
            //                    | AnchorStyles.Right
            //                    | AnchorStyles.Top;
            //m.Margin = new Padding(0, Ctrl.Height, 0, 0);
            //n.Margin = new Padding(0, Ctrl.Height, 0, 0);
            //m.
            //Items.Clear();
            //if (Ctrl == null)
            //    return;
            //_Grid = Ctrl;
            //var arr = _Grid.Controls.OfType<Control>().ToList();
            //ToolStripControlHost[] arr2 = new ToolStripControlHost[arr.Count];
            //int i = 0;
            //foreach (Control control in arr)
            //{

            //    arr2[i] = new ToolStripControlHost(control)
            //    {
            //        Dock = DockStyle.Fill,
            //        Margin = Padding.Empty,
            //        Padding = Padding.Empty,
            //        AutoSize = false,
            //        AutoToolTip = false,
            //        DoubleClickEnabled = true,
            //        Size = new Size(_Grid.Size.Width, _Grid.Size.Height),
            //    };
            //    Ctrl.Anchor = AnchorStyles.Bottom
            //                  | AnchorStyles.Left
            //                  | AnchorStyles.Right
            //                  | AnchorStyles.Top;
            //    arr2[i].ControlAlign = ContentAlignment.MiddleCenter;
            //    Items.Add(arr2[i]);
            //    i++;
            //    Items.Add(new ToolStripSeparator());
            //}
        }
        #endregion
        #region اینترفیس
        protected override void OnOpened(EventArgs e)
        {
            _Grid.Invalidate(_Grid.Region,true);
            base.OnOpened(e);
        }

        #endregion
        #region سازنده

        public Popup_ToolStrip()
        {
            InitializeComponent();

            Capture             = true;
            DropShadowEnabled   = false;
            AutoSize            = false;
            DoubleBuffered      = true;
            ResizeRedraw        = true;
            RightToLeft         = RightToLeft.Yes;
            
            LayoutStyle         = ToolStripLayoutStyle.Table;
            this.SizeChanged    +=OnSizeChanged;  
        }

        private void     OnSizeChanged                   (object sender, EventArgs eventArgs)
        {
            _Grid?.SetBounds(0,0,this.Width,Height- _StripSize, BoundsSpecified.Size);
        }
        public  void     InitializeTableLayoutSettings   ()
        {
            try
            {

                if (this.Items.Count > 1)
                    return;

                this.tableSettings = base.LayoutSettings as TableLayoutSettings;

                this.tableSettings.ColumnCount = this.Width / tileSize.Width;
                this.tableSettings.RowCount = this.Height / tileSize.Height;

                TableLayoutPanelCellPosition cellPos = new TableLayoutPanelCellPosition(0, 0);

                this.tableSettings.SetCellPosition(Host, cellPos);
                this.tableSettings.SetColumnSpan(Host, this.tableSettings.ColumnCount);
                this.tableSettings.SetRowSpan(Host, this.tableSettings.RowCount - 2);

                //=========================================
                ToolStrip strip = _Control
                                    .Controls
                                    .OfType<MS_Tool_Strip>()
                                    .FirstOrDefault();
                if (strip == null)
                    _Control.Controls.OfType<ToolStrip>().FirstOrDefault();

                if (strip == null)
                {
                    _StripSize = 0;
                    _Grid?.SetBounds(0, 0, this.Width, Height - _StripSize, BoundsSpecified.Size);
                    return;
                }
                int col = 0;
                foreach (ToolStripItem item in strip.Items.OfType<ToolStripItem>().Where(x => x.Visible).ToList())
                {
                    var n = item.CloneTo();
                    n.AutoSize = false;
                    n.Click += (sender, args) => { item.PerformClick(); };
                    Items.Add(n);
                    this.tableSettings.SetCellPosition(n, new TableLayoutPanelCellPosition(col++, this.tableSettings.RowCount - 1));

                }
            }
            catch (Exception)
            {
                
            }
        }
        #endregion
    }
}
