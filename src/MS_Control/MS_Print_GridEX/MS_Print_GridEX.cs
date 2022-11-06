using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_Control.MS_Print_GridEX
{
    public partial class MS_Print_GridEX : MS_Mother
    {
        private Form mOwnerForm;
        Janus.Windows.GridEX.GridEXPrintDocument _printDocument;

        public MS_Print_GridEX()
        {
            InitializeComponent();
        }

        #region مـتـد هـا
        protected override void OnClosed(System.EventArgs e)
        {
            mOwnerForm.WindowState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                mOwnerForm.Bounds = this.Bounds;
            }
            mOwnerForm.Show();
        }

        public void Showprint(Janus.Windows.GridEX.GridEXPrintDocument printDocument, Form ownerForm)
        {
            Janus.Windows.Common.Office2007ControlRenderer ctlRender = Janus.Windows.Common.Office2007SchemeInformation.GetControlRenderer(Janus.Windows.Common.Office2007ColorScheme.Default, Color.Empty);
            this.printPreviewControl1.BackColor = ctlRender.ControlColor;
            this.Text = "پـیـش نـمـایـش چــاپ لـیـسـت ";
            mOwnerForm = ownerForm;
            _printDocument = printDocument;

            if (mOwnerForm.WindowState == FormWindowState.Normal)
            {
                Bounds = mOwnerForm.Bounds;
            }
            else
            {
                this.WindowState = mOwnerForm.WindowState;
            }
            mOwnerForm.Hide();
            this.Show();
            this.Update();
            this.printPreviewControl1.Document = printDocument;
            this.printPreviewControl1.AutoZoom = true;
            _printDocument.DefaultPageSettings.Landscape = true;
        }
        #endregion

        private void printPreviewControl1_StartPageChanged(object sender, EventArgs e)
        {
            this.btn_Previous.Enabled = (this.printPreviewControl1.StartPage > 0);
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            try
            {
                this.printPreviewControl1.StartPage = this.printPreviewControl1.StartPage - 1;
            }
            catch { }
        }

        private void btn_Nex_Click(object sender, EventArgs e)
        {
            this.printPreviewControl1.StartPage = this.printPreviewControl1.StartPage + 1;
        }

        bool noeNamayesh = false;
        private void btn_Change_Click(object sender, EventArgs e)
        {
            _printDocument.DefaultPageSettings.Landscape = noeNamayesh;
            noeNamayesh = !noeNamayesh;
        }

        private void btn_Taki_Click(object sender, EventArgs e)
        {
            btn_Change.Checked = false;
            btn_Change.Checked = false;
            this.printPreviewControl1.AutoZoom = true;
            this.printPreviewControl1.Rows = 1;
            this.printPreviewControl1.Columns = 1;
        }

        private void btn_Dotaei_Click(object sender, EventArgs e)
        {
            this.btn_Change.Checked = false;
            this.btn_Change.Checked = false;
            this.printPreviewControl1.AutoZoom = true;
            this.printPreviewControl1.Rows = 1;
            this.printPreviewControl1.Columns = 2;
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.Document = this.printPreviewControl1.Document;
            if (this.pageSetupDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Printing.PrintDocument doc = null;
                doc = this.printPreviewControl1.Document;
                this.printPreviewControl1.Document = doc;
            }
        }

        private void rcmdPageSetup_Click(object sender, EventArgs e)
        {
            this.printPreviewControl1.Document.Print();
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            mOwnerForm.Show();
        }
    }
}
