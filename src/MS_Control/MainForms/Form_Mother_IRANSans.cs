using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MS_Control.MainForms
{
    public partial class Form_Mother_IRANSans : Office2007Form
    {
        #region Fields
        private Color   _Color =      Color.RoyalBlue;
        private bool    _Escap =      true;
        private bool    _Esc_Ex =     true;
        public  static  Icon          MS_Icon_Form = null;
        #endregion
        #region Consructor
        public Form_Mother_IRANSans()
        {
            InitializeComponent();
            if (MS_Icon_Form != null)
                this.Icon = MS_Icon_Form;
        }
        #endregion
        #region Property
        [Category("MS_Properties")]
        public bool MS_Escap
        {
            get { return _Escap; }
            set
            {
                _Escap = value;
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
        
        [Category("MS_Properties")]
        [Browsable(true)]
        public Icon MS_Icon_Main
        {
            get { return MS_Icon_Form; }
            set
            {
                this.Icon = value;
            }
        }
        #endregion
        #region Methods
        public void Avaz_Kardan_Title()
        {
            this.styleForm.ManagerColorTint = _Color;
            Validate();
        }
        #endregion

 
    }
}
