using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace MS_Control.Tarikh
{
    class MS_Tarikh_TextBox_Designer: ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                MS_Tarikh_TextBox control = (MS_Tarikh_TextBox)Control;

                if (control.AutoHeight)
                {
                    return SelectionRules.Moveable | SelectionRules.Visible | SelectionRules.LeftSizeable | SelectionRules.RightSizeable;
                }
                else
                {
                    return SelectionRules.AllSizeable | SelectionRules.Moveable | SelectionRules.Visible;
                }
            }
        }

        public override IList SnapLines
        {
            get
            {
                MS_Tarikh_TextBox control = (MS_Tarikh_TextBox)Control;

                IList snapLines = base.SnapLines;

                snapLines.Add(new SnapLine(SnapLineType.Baseline, control.Baseline));

                return snapLines;
            }
        }
    }
}
