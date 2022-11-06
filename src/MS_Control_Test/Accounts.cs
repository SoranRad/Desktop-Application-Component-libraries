using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightIdeasSoftware;
namespace MS_Control_Test
{
    public class Accounts
    {
        public Accounts()
        {

        }
        public uint      ID      { get; set; }
        public uint?     PID     { get; set; }

        //[OLVColumn(ImageAspectName = "Code")]
        public short    Code    { get; set; }
        //[OLVColumn(ImageAspectName = "Title")]
        public string   Title   { get; set; }

    }
}
