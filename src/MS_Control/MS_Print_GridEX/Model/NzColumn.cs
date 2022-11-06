using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;

namespace MS_Control.MS_Print_GridEX
{
    public class NzColumn
    {
        public string           Caption     { get; set; }
        public int              Width       { get; set; }
        public string           DataMember  { get; set; }
        public GridEXColumn     Column      { get; set; }
    }
}
