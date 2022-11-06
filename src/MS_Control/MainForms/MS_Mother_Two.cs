using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;
//****************
using DevComponents.DotNetBar;

namespace MS_Control
{
    public partial class MS_Mother_Two : Office2007Form
    {
        public MS_Mother_Two()
        {
            InitializeComponent();
            if (MS_Icon_Form != null)
                this.Icon = MS_Icon_Form;
        }
        #region فـیـلـد
        private Color _Color = Color.RoyalBlue;
        private Escap_Exit _Escap = Escap_Exit.Yes;
        private bool _Esc_Ex = true;
        public static Icon MS_Icon_Form = null;
        #endregion
        #region مـتـد
        public enum Escap_Exit
        {
            Yes = 0,
            No = 1,
        }
        protected void Escap_Ex()
        {
            switch (_Escap)
            {
                case Escap_Exit.Yes:
                    _Esc_Ex = true;
                    break;
                case Escap_Exit.No:
                    _Esc_Ex = false;
                    break;
            }
        }
        [Category("MS_Properties")]
        public Escap_Exit MS_Escap
        {
            get { return _Escap; }
            set
            {
                _Escap = value;
                Escap_Ex();
            }
        }

        [Category("MS_Properties")]
        public Color MS_Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                Avaz_Kardan_Title();
            }
        }
        public void Avaz_Kardan_Title()
        {
            this.styleForm.ManagerColorTint = _Color;
            Validate();
        }
        [Category("MS_Properties")]
        [Browsable(true)]
        public Icon MS_Icon_Main
        {
            get { return MS_Icon_Form; }
            set
            {
                MS_Icon_Form = value;
                this.Icon = value;
            }
        }
        #endregion

        private void MS_Mother_Two_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && _Esc_Ex)
                this.Close();
        }

    }
}
