using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Control.MS_Print_GridEX.Model
{
    public class NzCustomPrint
    {
        public NzCustomPrint()
        {
            Columns=new List<NzColumn>();
        }
        public byte                 KindPaper                   { get; set; }
        public byte                 StatePaper                  { get; set; }
        public bool                 AlternativeColor            { get; set; }
        public bool                 ColumnHeadColor             { get; set; }
        public bool                 FixColumnWidth              { get; set; }
        public bool                 InsertPageHorizantolly      { get; set; }
        public List<NzColumn>       Columns                     { get; set; }
    }
}
